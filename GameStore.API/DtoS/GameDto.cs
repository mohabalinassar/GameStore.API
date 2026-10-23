namespace GameStore.API.DtoS;

public record class GameDto(

    int Id,
    string Name,
    string Genre,
    decimal Price,
    string ImageUrl,
    int CategoryId,
    string CategoryName,
    DateOnly ReleaseDate
);