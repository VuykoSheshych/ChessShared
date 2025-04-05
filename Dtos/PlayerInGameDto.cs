namespace ChessShared.Dtos;

public record PlayerInGameDto(string Name, string ConnectionId, TimeSpan? TimeReserve = null);