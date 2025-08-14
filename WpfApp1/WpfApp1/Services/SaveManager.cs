using System.IO;
using System.Text.Json;

namespace WpfApp1.Classes;

public class SaveManager
{
    private static string SavePath => Path.Combine(AppContext.BaseDirectory, "savegame.json");

    public static void SaveAll(List<BattleMap> battleMaps)
    {
        var gameSave = new GameSave { BattleMaps = battleMaps };

        var folder = Path.GetDirectoryName(SavePath);
        if (!Directory.Exists(folder))
            Directory.CreateDirectory(folder);

        string json = JsonSerializer.Serialize(gameSave, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(SavePath, json);
    }

    public static List<BattleMap> LoadAll()
    {
        if (!File.Exists(SavePath))
            return new List<BattleMap>();

        string json = File.ReadAllText(SavePath);
        var gameSave = JsonSerializer.Deserialize<GameSave>(json);
        return gameSave?.BattleMaps ?? new List<BattleMap>();
    }
}