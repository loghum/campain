using Battlefield.Components;
using Battlefield.Models;
using Battlefield.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.SignalR.Client;

namespace Battlefield.Pages;

public class BattlefieldMapBase : ComponentBase
{
    [Inject] protected BattlefieldService BattlefieldService { get; set; } = default!;
    [Inject] protected NavigationManager NavManager { get; set; } = default!;

    [Parameter] public string? BattlefieldId { get; set; }

    protected BattlefieldModel? CurrentBattlefield { get; set; }
    protected HubConnection? hubConnection;

    protected Token? selectedToken;
    protected bool isDragging;
    protected int tokenOffsetX;
    protected int tokenOffsetY;
    
    
    public string MeasurementSelectedShape { get; set; }
    public (double X, double Y) MeasurementStart { get; set; }
    public (double X, double Y) MeasurementEnd { get; set; }
    public bool IsMeasuring { get; set; }

    // Zoom & Pan
    protected double OffsetX { get; set; } = 0;
    protected double OffsetY { get; set; } = 0;
    protected int MapWidth { get; set; } = 1920;
    protected int MapHeight { get; set; } = 1080;
    protected int TokenSize { get; set; } = 50;

    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl("http://localhost:5126/battlehub")
            .WithAutomaticReconnect()
            .Build();

        await hubConnection.StartAsync();

        hubConnection.On<string>("ActiveBattlefieldChanged", async battlefieldId =>
        {
            if (!string.IsNullOrEmpty(BattlefieldId))
                await hubConnection.InvokeAsync("LeaveBattlefield", BattlefieldId);

            BattlefieldId = battlefieldId;
            CurrentBattlefield = BattlefieldService.GetBattlefield(battlefieldId);

            if (!string.IsNullOrEmpty(battlefieldId))
                await hubConnection.InvokeAsync("JoinBattlefield", battlefieldId);

            await InvokeAsync(StateHasChanged);
        });

        hubConnection.On<string, int, int>("TokenMoved", (tokenId, x, y) =>
        {
            if (CurrentBattlefield == null) return;

            var token = CurrentBattlefield.Tokens.FirstOrDefault(t => t.Id == tokenId);
            if (token != null)
            {
                token.X = x;
                token.Y = y;
                InvokeAsync(StateHasChanged);
            }
        });

        hubConnection.On<Token>("TokenCreated", token =>
        {
            if (CurrentBattlefield == null) return;

            CurrentBattlefield.Tokens.Add(token);
            InvokeAsync(StateHasChanged);
        });
    }

    protected bool CanMoveToken(Token token, bool isDM) => isDM || !token.DmOnly;

    protected void OnTokenMouseDown(MouseEventArgs e, Token token)
    {
        selectedToken = token;
        tokenOffsetX = (int)(e.ClientX - (token.X * CurrentBattlefield.Zoom + OffsetX));
        tokenOffsetY = (int)(e.ClientY - (token.Y * CurrentBattlefield.Zoom + OffsetY));
        isDragging = true;
    }

    protected void OnMouseMove(MouseEventArgs e)
    {
        if (!isDragging || selectedToken == null) return;

        selectedToken.X = (int)((e.ClientX - tokenOffsetX - OffsetX) / CurrentBattlefield.Zoom);
        selectedToken.Y = (int)((e.ClientY - tokenOffsetY - OffsetY) / CurrentBattlefield.Zoom);
        StateHasChanged();
    }

    protected async Task OnMouseUp()
    {
        if (selectedToken != null && hubConnection != null)
        {
            await hubConnection.SendAsync("MoveToken", BattlefieldId, selectedToken.Id, selectedToken.X, selectedToken.Y);
            BattlefieldService.UpdateTokenPosition(BattlefieldId!, selectedToken.Id, selectedToken.X, selectedToken.Y);
        }
        selectedToken = null;
        isDragging = false;
    }
    
    public Task HandleTokenMouseDown(TokenMouseDownArgs args)
    {
        if (args?.E != null && args.Token != null)
        {
            // call your existing method that handles a token mouse down (expects MouseEventArgs, Token)
            OnTokenMouseDown(args.E, args.Token);
        }
        return Task.CompletedTask;
    }
    
    public void HandleMeasurementMouseDown(MouseEventArgs e)
    {
        if (!string.IsNullOrEmpty(MeasurementSelectedShape))
        {
            MeasurementStart = (e.OffsetX, e.OffsetY);
            MeasurementEnd = MeasurementStart;
            IsMeasuring = true;
        }
    }

    public void HandleMeasurementMouseMove(MouseEventArgs e)
    {
        if (IsMeasuring)
        {
            MeasurementEnd = (e.OffsetX, e.OffsetY);
            StateHasChanged();
        }
    }

    public void HandleMeasurementMouseUp(MouseEventArgs e)
    {
        if (IsMeasuring)
        {
            MeasurementEnd = (e.OffsetX, e.OffsetY);
            IsMeasuring = false;
            StateHasChanged();
        }
    }
    
    public void OnMapMouseDown(MouseEventArgs e)
    {
        // TODO: Implement map-specific mouse down logic here (e.g., select, pan, etc.)
    }
}
