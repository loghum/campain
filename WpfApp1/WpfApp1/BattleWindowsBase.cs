using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using WpfApp1.Classes;

namespace WpfApp1;

public class BattleWindowsBase : Window
{
    protected bool IsDm;
    private BattleMap _currentMap;
    private Canvas _battleCanvas;
    private Token _dragToken;
    private Point _lastPos;
    
    protected void SetCurrentMap(BattleMap map)
    {
        _currentMap = map;
    }
    
    protected void RenderTokens(Canvas battleCanvas)
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
                stack.Children.Add(token.CreateNameText());

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