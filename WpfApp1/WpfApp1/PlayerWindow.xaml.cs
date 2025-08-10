using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.Classes;

namespace WpfApp1
{
    public partial class PlayerWindow: Window
    {
        private readonly bool _isDm;
        private BattleMap _currentMap;

        private Token _dragToken;
        private Point _lastPos;

        public PlayerWindow(bool isDm, List<BattleMap> battleMaps)
        {
            _isDm = isDm;
            InitializeComponent();

            // Populate map selector combobox
            MapSelector.ItemsSource = battleMaps;
            MapSelector.DisplayMemberPath = "Name";
            MapSelector.SelectionChanged += MapSelector_SelectionChanged;

            if (battleMaps.Count > 0)
            {
                MapSelector.SelectedIndex = 0;
                SwitchToMap(battleMaps[0]);
            }
        }
        
        public void SwitchToMapFromOutside(BattleMap map)
        {
            _currentMap = map;
            MapBackgroundImage.Source = new BitmapImage(new Uri(map.BackgroundImagePath, UriKind.RelativeOrAbsolute));
            RenderTokens();
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

            MapBackgroundImage.Source = new BitmapImage(new Uri(map.BackgroundImagePath, UriKind.RelativeOrAbsolute));

            _currentMap.GameState.StateChanged += OnStateChanged;

            RenderTokens();
        }

        private void OnStateChanged()
        {
            RenderTokens();

            // **No saving here, only update UI**
        }

        protected virtual void RenderTokens()
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
                
                Canvas.SetLeft(stack, token.X);
                Canvas.SetTop(stack, token.Y);

                // DM can move all tokens; players can move only their own
                var canDrag = _isDm || token.Owner == "Player";

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
