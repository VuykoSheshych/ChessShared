#nullable enable

namespace ChessShared.Dtos;

public record UserDto(string Id, string Name, int EloRating, byte[]? Avatar = null);