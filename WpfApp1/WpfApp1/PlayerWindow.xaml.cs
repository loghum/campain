using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfApp1.Classes;

namespace WpfApp1
{
    public partial class PlayerWindow : BattleWindowsBase
    {
        public PlayerWindow(bool isDm, List<BattleMap> battleMaps)
        {
            IsDm = isDm;
            InitializeComponent();
            
            MapSelector.ItemsSource = battleMaps;
            MapSelector.DisplayMemberPath = "Name";
            MapSelector.SelectionChanged += MapSelector_SelectionChanged;

            if (battleMaps.Count <= 0) return;
            
            MapSelector.SelectedIndex = 0;
            Switch(BattleCanvas, battleMaps[0], MapBackgroundImage);
        }

        public void SwitchToMapFromOutside(BattleMap map)
        {
            Switch(BattleCanvas, map, MapBackgroundImage);
        }

        private void MapSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MapSelector.SelectedItem is BattleMap selectedMap)
            {
                Switch(BattleCanvas, selectedMap, MapBackgroundImage);
            }
        }
    }
}
