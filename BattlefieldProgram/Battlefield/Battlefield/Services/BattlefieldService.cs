using System.Net.Http.Headers;
using Battlefield.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace Battlefield.Services;

public class BattlefieldService
{
    private readonly Dictionary<string, BattlefieldModel> _battlefields = new();
    private readonly HttpClient _httpClient;

    public BattlefieldService(HttpClient? httpClient = null)
    {
        _httpClient = httpClient ?? new HttpClient();
       var model1= new BattlefieldModel
        {
            Id = "1",
            Name = "Battlefield 1",
            BackgroundImageUrl = "http://localhost:5126/images/background.jpg",
            Tokens = new List<Token> { new Token
                {
                    Id = "1",
                    Name = "Lizard 1",
                    X = 10,
                    Y = 20,
                    Color = "red",
                    DmOnly = true,
                    ImageUrl =  $"http://localhost:5126/images/token.png",
                    GridSize = 2
                },
                new Token
                {
                    Id = "2",
                    Name = "Lizard 2",
                    X = 220,
                    Y = 330,
                    Color = "blue",
                    DmOnly = false,
                    ImageUrl =  $"http://localhost:5126/images/token.png"
                }
            }
        };
        var model2 =new BattlefieldModel
        {
            Id = "2",
            Name = "Battlefield 2",
            BackgroundImageUrl = "http://localhost:5126/images/background.jpg",
            Tokens = new List<Token> { new Token
                {
                    Id = "1",
                    X = 400,
                    Y = 400,
                    Color = "red",
                    DmOnly = true,
                    ImageUrl =  $"http://localhost:5126/images/token.png"
                },
            }
        };
        _battlefields[model1.Id] = model1;
        _battlefields[model2.Id] = model2;
        
    }
    public List<BattlefieldModel> GetBattlefields() => _battlefields.Values.ToList();

    public BattlefieldModel GetBattlefield(string id) =>
        _battlefields.ContainsKey(id) ? _battlefields[id] : throw new Exception("Battlefield not found");

    public void UpdateTokenPosition(string battlefieldId, string tokenId, int x, int y)
    {
        var battlefield = GetBattlefield(battlefieldId);
        var token = battlefield.Tokens.FirstOrDefault(t => t.Id == tokenId);
        if (token != null)
        {
            token.X = x;
            token.Y = y;
        }
    }
    
    public async Task<Token?> CreateTokenAsync(string battlefieldId, IBrowserFile? selectedFile)
    {
        var battlefield = GetBattlefield(battlefieldId);
        if (battlefield == null) return null;

        string? uploadedImageUrl = null;

        if (selectedFile != null)
        {
            using var content = new MultipartFormDataContent();
            using var fileStream = selectedFile.OpenReadStream(maxAllowedSize: 5 * 1024 * 1024);
            using var fileContent = new StreamContent(fileStream);
            fileContent.Headers.ContentType = new MediaTypeHeaderValue(selectedFile.ContentType ?? "application/octet-stream");
            content.Add(fileContent, "file", selectedFile.Name);

            var response = await _httpClient.PostAsync("http://localhost:5126/api/upload", content);
            response.EnsureSuccessStatusCode();

            uploadedImageUrl = await response.Content.ReadAsStringAsync(); // server returns the image path (maybe quoted)
            uploadedImageUrl = uploadedImageUrl?.Trim('\"'); // remove potential quotes
        }

        var token = new Token
        {
            Id = Guid.NewGuid().ToString(),
            X = 100,
            Y = 100,
            DmOnly = false,
            ImageUrl = string.IsNullOrWhiteSpace(uploadedImageUrl) ? null : $"http://localhost:5126{uploadedImageUrl}",
            Color = "transparent"
        };

        battlefield.Tokens.Add(token);

        // Service should not call UI methods (StateHasChanged) or hub directly.
        // If you need to notify UI or SignalR, expose events or return the token and let the consumer handle notifications.

        return token;
    }
}