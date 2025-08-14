using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfApp1.Classes;

namespace WpfApp1
{
    public partial class PlayerWindow: BattleWindowsBase
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
            string fullPath = Path.Combine(AppContext.BaseDirectory, map.BackgroundImagePath);
            
            if (!File.Exists(fullPath))
                throw new FileNotFoundException($"Image not found: {fullPath}");
            
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullPath, UriKind.Absolute);
            bitmap.CacheOption = BitmapCacheOption.OnLoad; // avoids file lock
            bitmap.EndInit();
            
            MapBackgroundImage.Source = bitmap;
            RenderTokens(BattleCanvas, _isDm, _currentMap);
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
        }

        private void OnStateChanged()
        {
            RenderTokens(BattleCanvas, _isDm, _currentMap);

            // **No saving here, only update UI**
        }
    }
}
