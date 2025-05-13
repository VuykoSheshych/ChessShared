using ChessShared.Enums;

namespace ChessShared.Dtos;

/// <summary>
/// Represents a player's rating change as a result of a completed game.
/// </summary>
public record PlayerRatingChangeDto
{
	/// <summary>
	/// The username of the player.
	/// </summary>
	public string UserName { get; init; }

	/// <summary>
	/// The player's rating before the game.
	/// </summary>
	public int PreviousRating { get; init; }

	/// <summary>
	/// The player's rating after the game.
	/// </summary>
	public int NewRating { get; init; }

	/// <summary>
	/// The result of the game for this player: "Win", "Loss", or "Draw".
	/// </summary>
	public PlayerGameResult Result { get; init; }

	/// <summary>
	/// Initializes a new instance of the <see cref="PlayerRatingChangeDto"/> record.
	/// </summary>
	/// <param name="userName">The username of the player.</param>
	/// <param name="previousRating">The rating before the game.</param>
	/// <param name="newRating">The rating after the game.</param>
	/// <param name="result">The result for this player ("Win", "Loss", "Draw").</param>
	public PlayerRatingChangeDto(string userName, int previousRating, int newRating, PlayerGameResult result)
	{
		UserName = userName;
		PreviousRating = previousRating;
		NewRating = newRating;
		Result = result;
	}
}