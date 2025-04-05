#nullable enable

namespace ChessShared.Dtos;

public record MoveDto(string From, string To, string? Promotion = null);