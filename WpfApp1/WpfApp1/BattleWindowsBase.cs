using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.Classes;
using Path = System.IO.Path;

namespace WpfApp1;

public class BattleWindowsBase : Window
{
    protected bool IsDm;
    public BattleMap _currentMap;
    private Canvas _battleCanvas;
    private Token _dragToken;
    private Point _lastPos;
    
    protected MeasurementMode SelectedShape = MeasurementMode.None;
    protected Point? _measurementStart;
    protected Shape _previewShape;
    protected TextBlock _measurementLabel;
    
    public List<MeasurementMode> ShapeOptions { get; } = 
        Enum.GetValues(typeof(MeasurementMode)).Cast<MeasurementMode>().ToList();


    protected Shape CreateShape(MeasurementMode shape)
    {
        Shape s = shape switch
        {
            MeasurementMode.Line => new Line
            {
                Stroke = Brushes.Red,
                StrokeThickness = 2
            },
            MeasurementMode.Square => new Rectangle
            {
                Stroke = Brushes.Blue,
                StrokeThickness = 2
            },
            MeasurementMode.Circle => new Ellipse
            {
                Stroke = Brushes.Green,
                StrokeThickness = 2
            },
            MeasurementMode.Cone => new Polygon
            {
                Stroke = Brushes.Orange,
                StrokeThickness = 2
            },
            _ => null
        };
        return s;
    }

    protected void UpdateShape(Shape shape, Point start, Point end, MeasurementMode type)
    {
        switch (shape)
        {
            case Line line:
                line.X1 = start.X;
                line.Y1 = start.Y;
                line.X2 = end.X;
                line.Y2 = end.Y;
                break;

            case Rectangle rect:
                Canvas.SetLeft(rect, Math.Min(start.X, end.X));
                Canvas.SetTop(rect, Math.Min(start.Y, end.Y));
                rect.Width = Math.Abs(start.X - end.X);
                rect.Height = Math.Abs(start.Y - end.Y);
                break;

            case Ellipse ellipse:
                Canvas.SetLeft(ellipse, Math.Min(start.X, end.X));
                Canvas.SetTop(ellipse, Math.Min(start.Y, end.Y));
                ellipse.Width = Math.Abs(start.X - end.X);
                ellipse.Height = Math.Abs(start.Y - end.Y);
                break;

            case Polygon poly when type == MeasurementMode.Cone:
                double dx = end.X - start.X;
                double dy = end.Y - start.Y;
                double angle = Math.Atan2(dy, dx);
                double length = Math.Sqrt(dx * dx + dy * dy);

                poly.Points = new PointCollection
                {
                    start,
                    new Point(start.X + length * Math.Cos(angle - Math.PI / 6),
                              start.Y + length * Math.Sin(angle - Math.PI / 6)),
                    new Point(start.X + length * Math.Cos(angle + Math.PI / 6),
                              start.Y + length * Math.Sin(angle + Math.PI / 6))
                };
                break;
        }
    }

    protected double DistanceInPixels(Point p1, Point p2)
    {
        double dx = p2.X - p1.X;
        double dy = p2.Y - p1.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
    
    
    private void RenderTokens(Canvas battleCanvas)
    {
            battleCanvas.Children.Clear();

            foreach (var token in _currentMap.GameState.Tokens)
            {
                var stack = new StackPanel
                {
                    Orientation = Orientation.Vertical,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Cursor = Cursors.Hand
                };
                
                stack.Children.Add(token.CreateToken());

                if (IsDm)
                {
                    stack.Children.Add(token.CreateNameText());
                }

                Canvas.SetLeft(stack, token.X);
                Canvas.SetTop(stack, token.Y);

                // DM can move all tokens; players can move only their own
                var canDrag = IsDm || token.Owner == "Player";

                if (canDrag)
                {
                    stack.MouseLeftButtonDown += (s, e) =>
                    {
                        _dragToken = token;
                        _lastPos = e.GetPosition(battleCanvas);
                        stack.CaptureMouse();
                        e.Handled = true;
                    };

                    stack.MouseMove += (s, e) =>
                    {
                        if (_dragToken == null || e.LeftButton != MouseButtonState.Pressed) return;
                        
                        var pos = e.GetPosition(battleCanvas);
                        var dx = pos.X - _lastPos.X;
                        var dy = pos.Y - _lastPos.Y;
                        _lastPos = pos;
                        _currentMap.GameState.UpdateTokenPosition(_dragToken, _dragToken.X + dx, _dragToken.Y + dy);
                    };

                    stack.MouseLeftButtonUp += (s, e) =>
                    {
                        _dragToken = null;
                        stack.ReleaseMouseCapture();
                        e.Handled = true;
                    };
                }
                battleCanvas.Children.Add(stack);
            }
    }
    
    protected void Switch(Canvas battleCanvas,BattleMap map, Image mapBackgroundImage)
    {
        _battleCanvas = battleCanvas;
        _currentMap = map;
        if (_currentMap != null)
        {
            _currentMap.GameState.StateChanged -= OnStateChanged;
        }
        
        _currentMap = map;

        var fullPath = Path.Combine(AppContext.BaseDirectory, map.BackgroundImagePath);
            
        if (!File.Exists(fullPath))
            throw new FileNotFoundException($"Image not found: {fullPath}");
            
        var bitmap = new BitmapImage();
        bitmap.BeginInit();
        bitmap.UriSource = new Uri(fullPath, UriKind.Absolute);
        bitmap.CacheOption = BitmapCacheOption.OnLoad; // avoids file lock
        bitmap.EndInit();
            
        mapBackgroundImage.Source = bitmap;

        _currentMap.GameState.StateChanged += OnStateChanged;

        RenderTokens(_battleCanvas);
    }
    private void OnStateChanged()
    {
        RenderTokens(_battleCanvas);
    }
}