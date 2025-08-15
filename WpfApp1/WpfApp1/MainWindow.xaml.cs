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
        private readonly List<BattleMap> _battleMaps;
        
        public event Action<BattleMap> MapChanged;

        public MainWindow(bool isDm, List<BattleMap> battleMaps)
        {
            _battleMaps = battleMaps;
            IsDm = isDm;
            InitializeComponent();
            
            MapSelector.ItemsSource = _battleMaps;
            MapSelector.DisplayMemberPath = "Name";
            MapSelector.SelectionChanged += MapSelector_SelectionChanged;

            if (_battleMaps.Count <= 0) return;
            
            MapSelector.SelectedIndex = 0;
            Switch(BattleCanvas, _battleMaps[0], MapBackgroundImage);
            MapChanged?.Invoke(_battleMaps[0]);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveManager.SaveAll(_battleMaps);
        }

        private void MapSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MapSelector.SelectedItem is not BattleMap selectedMap) return;
            Switch(BattleCanvas, selectedMap, MapBackgroundImage);
            MapChanged?.Invoke(selectedMap);
        }
    }
}
