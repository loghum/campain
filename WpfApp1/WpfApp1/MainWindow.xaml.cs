using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfApp1.Classes;

namespace WpfApp1
{
    public partial class MainWindow : BattleWindowsBase
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

            RenderTokens(BattleCanvas, _isDm, _currentMap);
            
            MapChanged?.Invoke(map);  // Notify listeners
        }

        private void OnStateChanged()
        {
            RenderTokens(BattleCanvas, _isDm, _currentMap);

            // **No saving here, only update UI**
        }

        
    }
}
