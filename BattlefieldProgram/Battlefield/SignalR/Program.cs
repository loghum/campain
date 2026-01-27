using Microsoft.AspNetCore.SignalR;
using SignalR;

var builder = WebApplication.CreateBuilder(args);

// Add SignalR services
builder.Services.AddSignalR();

// CORS for Blazor WASM dev
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", policy =>
        policy
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials()
            .SetIsOriginAllowed(_ => true)
    );
});

var app = builder.Build();

// Serve static files (for uploaded images)
app.UseStaticFiles();

// Apply CORS before hubs
app.UseCors("CorsPolicy");

// SignalR hubs
app.MapHub<ChatHub>("/chathub");
app.MapHub<BattleHub>("/battlehub");

// Minimal API for image upload
app.MapPost("/api/upload", async (HttpRequest request, IWebHostEnvironment env) =>
{
    if (!request.HasFormContentType)
        return Results.BadRequest("Form content type required.");

    var form = await request.ReadFormAsync();
    var file = form.Files.FirstOrDefault();
    if (file == null || file.Length == 0)
        return Results.BadRequest("No file uploaded.");

    var uploadsFolder = Path.Combine(env.WebRootPath ?? "wwwroot", "images");
    Directory.CreateDirectory(uploadsFolder);

    var filePath = Path.Combine(uploadsFolder, file.FileName);

    using var stream = new FileStream(filePath, FileMode.Create);
    await file.CopyToAsync(stream);

    var relativePath = $"/images/{file.FileName}";
    return Results.Ok(relativePath);
}).RequireCors("CorsPolicy");

app.Run();