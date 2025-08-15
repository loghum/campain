namespace WpfApp1.Classes;

public class BattleMap
{
    public string Name { get; set; }
    public string BackgroundImagePath { get; set; }
    public GameState GameState { get; set; } = new GameState();
    public override string ToString() => Name; // handig voor binding in combobox
    
    public int PixelsPerFeet { get; set; }
}