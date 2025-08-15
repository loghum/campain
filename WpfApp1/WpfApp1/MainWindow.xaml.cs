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

            MeasureSelector.ItemsSource = Enum.GetValues(typeof(MeasurementMode));
            MeasureSelector.SelectedItem = MeasurementMode.None;
            
            BattleCanvas.MouseLeftButtonDown += BattleCanvas_MouseLeftButtonDown;
            BattleCanvas.MouseMove += BattleCanvas_MouseMove;
            BattleCanvas.MouseLeftButtonUp += BattleCanvas_MouseLeftButtonUp;

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
        
        private void BattleCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (MeasureSelector.SelectedIndex == MeasurementMode.None)
                return;

            _measurementStart = e.GetPosition(BattleCanvas);

            _measurementLabel = new TextBlock
            {
                Foreground = Brushes.Black,
                FontWeight = FontWeights.Bold,
                Background = Brushes.White,
                Padding = new Thickness(2)
            };
            BattleCanvas.Children.Add(_measurementLabel);

            _previewShape = CreateShape(SelectedShape);
            BattleCanvas.Children.Add(_previewShape);
            Canvas.SetLeft(_previewShape, _measurementStart.Value.X);
            Canvas.SetTop(_previewShape, _measurementStart.Value.Y);
        }

        private void BattleCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (_measurementStart == null || e.LeftButton != MouseButtonState.Pressed)
                return;

            var pos = e.GetPosition(BattleCanvas);
            UpdateShape(_previewShape, _measurementStart.Value, pos, SelectedShape);

            double pixelDistance = DistanceInPixels(_measurementStart.Value, pos);
            double feet = pixelDistance / _currentMap.PixelsPerFeet;

            _measurementLabel.Text = $"{feet:F1} ft";
            Canvas.SetLeft(_measurementLabel, (pos.X + _measurementStart.Value.X) / 2);
            Canvas.SetTop(_measurementLabel, (pos.Y + _measurementStart.Value.Y) / 2 - 20);
        }

        protected void BattleCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            _measurementStart = null;
            if (_previewShape != null)
            {
                BattleCanvas.Children.Remove(_previewShape);
                _previewShape = null;
            }
            if (_measurementLabel != null)
            {
                BattleCanvas.Children.Remove(_measurementLabel);
                _measurementLabel = null;
            }
        }
    }
}
