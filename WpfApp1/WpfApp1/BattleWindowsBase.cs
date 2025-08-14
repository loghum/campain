using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp1.Classes;

namespace WpfApp1;

public class BattleWindowsBase : Window
{
    
    protected Token _dragToken;
    protected Point _lastPos;
    
    
    protected virtual void RenderTokens(Canvas BattleCanvas, bool _isDm, BattleMap _currentMap)
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