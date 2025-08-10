using System.Windows;
using WpfApp1.Classes;

namespace WpfApp1
{
    public partial class App : Application
    {
        private List<BattleMap> _battleMaps;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Load battle maps once (load saved or create defaults)
            _battleMaps = SaveManager.LoadAll();

            if (_battleMaps == null || _battleMaps.Count == 0)
            {
                // Create default maps if none loaded
                _battleMaps = new List<BattleMap>
                {
                    new BattleMap
                    {
                        Name = "City",
                        BackgroundImagePath = "Images/test.jpg",
                        GameState = new GameState()
                    },
                    new BattleMap
                    {
                        Name = "Dungeon",
                        BackgroundImagePath = "Images/test2.jpg",
                        GameState = new GameState()
                    }
                };
            }

            var dmWindow = new MainWindow(true, _battleMaps);
            dmWindow.Title = "DM View";
            

            var playerWindow = new PlayerWindow(false, _battleMaps);
            playerWindow.Title = "Player View";
            
            
            dmWindow.MapChanged += (newMap) =>
            {
                playerWindow.SwitchToMapFromOutside(newMap);
            };
            
            dmWindow.Show();
            playerWindow.Show();
        }
    }
}