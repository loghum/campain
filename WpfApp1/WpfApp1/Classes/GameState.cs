namespace WpfApp1.Classes
{
    public class GameState
    {
        public List<Token> Tokens { get; set; } = new();

        public event Action StateChanged;

        public void UpdateTokenPosition(Token token, double newX, double newY)
        {
            token.X = newX;
            token.Y = newY;
            StateChanged?.Invoke();
        }
    }
}