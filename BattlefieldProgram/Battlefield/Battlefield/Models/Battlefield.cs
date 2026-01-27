using Battlefield.Models;

public class BattlefieldModel
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = "New Battlefield";
    public string? BackgroundImageUrl { get; set; }
    public List<Token> Tokens { get; set; } = new();
    
    
    public double Zoom { get; set; } = 1;
    public double TokenSize { get; set;  } = 50;
}