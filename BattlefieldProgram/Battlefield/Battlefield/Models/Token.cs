namespace Battlefield.Models;

public class Token
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public int X { get; set; }
    public int Y { get; set; }
    public bool DmOnly { get; set; }
    public string Color { get; set; }
    
    public string ImageUrl { get; set; }
    
    public string Xpx => X + "px";
    public string Ypx => Y + "px";
    
    public int GridSize { get; set; } = 1;
    public string Name { get; set; } = "";
}