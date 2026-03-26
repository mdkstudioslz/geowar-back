using Geowar.Back.Api.Hubs;
using Geowar.Back.Modules.Players;
using Geowar.Back.Modules.World;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddSignalR();
builder.Services
    .AddPlayersModule()
    .AddWorldModule();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapHub<WorldHub>("/hubs/world");

app.Run();
