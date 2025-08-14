using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfApp1.Classes;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private readonly bool _isDm;
        private readonly List<BattleMap> _battleMaps;
        private BattleMap _currentMap;

        private Token _dragToken;
        private Point _lastPos;
        
        public event Action<BattleMap> MapChanged;

        public MainWindow(bool isDm, List<BattleMap> battleMaps)
        {
            _battleMaps = battleMaps;
            _isDm = isDm;
            InitializeComponent();
            
            // Populate map selector combobox
            MapSelector.ItemsSource = _battleMaps;
            MapSelector.DisplayMemberPath = "Name";
            MapSelector.SelectionChanged += MapSelector_SelectionChanged;

            if (_battleMaps.Count <= 0) return;
            MapSelector.SelectedIndex = 0;
            SwitchToMap(_battleMaps[0]);

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveManager.SaveAll(_battleMaps);
        }

        private void MapSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MapSelector.SelectedItem is BattleMap selectedMap)
            {
                SwitchToMap(selectedMap);
            }
        }

        private void SwitchToMap(BattleMap map)
        {
            if (_currentMap != null)
            {
                _currentMap.GameState.StateChanged -= OnStateChanged;
            }

            _currentMap = map;

            string fullPath = Path.Combine(AppContext.BaseDirectory, map.BackgroundImagePath);
            
            if (!File.Exists(fullPath))
                throw new FileNotFoundException($"Image not found: {fullPath}");
            
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullPath, UriKind.Absolute);
            bitmap.CacheOption = BitmapCacheOption.OnLoad; // avoids file lock
            bitmap.EndInit();
            
            MapBackgroundImage.Source = bitmap;

            _currentMap.GameState.StateChanged += OnStateChanged;

            RenderTokens();
            
            MapChanged?.Invoke(map);  // Notify listeners
        }

        private void OnStateChanged()
        {
            RenderTokens();

            // **No saving here, only update UI**
        }

        private void RenderTokens()
        {
            BattleCanvas.Children.Clear();

            foreach (var token in _currentMap.GameState.Tokens)
            {
                var stack = new StackPanel
                {
                    Orientation = Orientation.Vertical,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Cursor = Cursors.Hand
                };
                
                stack.Children.Add(token.CreateToken());
                stack.Children.Add(token.CreateNameText());

                Canvas.SetLeft(stack, token.X);
                Canvas.SetTop(stack, token.Y);

                // DM can move all tokens; players can move only their own
                bool canDrag = _isDm || token.Owner == "Player";

                if (canDrag)
                {
                    stack.MouseLeftButtonDown += (s, e) =>
                    {
                        _dragToken = token;
                        _lastPos = e.GetPosition(BattleCanvas);
                        stack.CaptureMouse();
                        e.Handled = true;
                    };

                    stack.MouseMove += (s, e) =>
                    {
                        if (_dragToken != null && e.LeftButton == MouseButtonState.Pressed)
                        {
                            var pos = e.GetPosition(BattleCanvas);
                            var dx = pos.X - _lastPos.X;
                            var dy = pos.Y - _lastPos.Y;
                            _lastPos = pos;
                            _currentMap.GameState.UpdateTokenPosition(_dragToken, _dragToken.X + dx, _dragToken.Y + dy);
                        }
                    };

                    stack.MouseLeftButtonUp += (s, e) =>
                    {
                        _dragToken = null;
                        stack.ReleaseMouseCapture();
                        e.Handled = true;
                    };
                }

                BattleCanvas.Children.Add(stack);
            }
        }
    }
}
