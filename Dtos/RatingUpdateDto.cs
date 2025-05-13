using System;
using System.Collections.Generic;

namespace ChessShared.Dtos;

/// <summary>
/// Represents the result of a completed chess game, including rating updates for each player.
/// </summary>
public record RatingUpdateDto
{
	/// <summary>
	/// The unique identifier of the completed game.
	/// </summary>
	public string GameId { get; init; }

	/// <summary>
	/// The UTC timestamp when the game ended.
	/// </summary>
	public DateTime GameFinishedAt { get; init; }

	/// <summary>
	/// A list of rating updates for players involved in the game.
	/// </summary>
	public List<PlayerRatingChangeDto> Players { get; init; }

	/// <summary>
	/// Initializes a new instance of the <see cref="RatingUpdateDto"/> record.
	/// </summary>
	/// <param name="gameId">The unique identifier of the game.</param>
	/// <param name="gameFinishedAt">The UTC date and time when the game finished.</param>
	/// <param name="players">A list of rating updates for each player.</param>
	public RatingUpdateDto(string gameId, DateTime gameFinishedAt, List<PlayerRatingChangeDto> players)
	{
		GameId = gameId;
		GameFinishedAt = gameFinishedAt;
		Players = players;
	}
}