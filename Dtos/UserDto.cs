#nullable enable

namespace ChessShared.Dtos;

/// <summary>
/// Represents a user with basic profile information.
/// </summary>
public record UserDto
{
	/// <summary>
	/// The unique identifier of the user.
	/// </summary>
	public string Id { get; init; } = string.Empty;

	/// <summary>
	/// The display name of the user.
	/// </summary>
	public string Name { get; init; } = string.Empty;

	/// <summary>
	/// The user's current Elo rating.
	/// </summary>
	public int EloRating { get; init; }

	/// <summary>
	/// An optional avatar image for the user, stored as a byte array.
	/// </summary>
	public byte[]? Avatar { get; init; } = null;

	/// <summary>
	/// Initializes a new instance of the <see cref="UserDto"/> record.
	/// </summary>
	/// <param name="id">The unique identifier of the user.</param>
	/// <param name="name">The display name of the user.</param>
	/// <param name="eloRating">The user's Elo rating.</param>
	/// <param name="avatar">Optional avatar image for the user.</param>
	public UserDto(string id, string name, int eloRating, byte[]? avatar = null)
	{
		Id = id;
		Name = name;
		EloRating = eloRating;
		Avatar = avatar;
	}
}