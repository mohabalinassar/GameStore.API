using GameStore.API.DtoS;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<GameDto> games = new List<GameDto>
{
    new GameDto { Id = 1, Name = "The Legend of Zelda: Breath of the Wild", Genre = "Action-adventure", Price = 59.99m , ReleaseDate = new DateOnly(2017, 3, 3) },
    new GameDto { Id = 2, Name = "Super Mario Odyssey", Genre = "Platformer", Price = 49.99m, ReleaseDate = new DateOnly(2017, 10, 27) },
};

app.MapGet("/games", () => games);

app.Run();
 

 