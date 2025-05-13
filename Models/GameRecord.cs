using System;
using System.Collections.Generic;
using ChessShared.Enums;

namespace ChessShared.Models;

/// <summary>
/// Represents a record of a completed chess game, including players, moves, and result.
/// </summary>
public class GameRecord
{
	/// <summary>
	/// The unique identifier for the game record.
	/// </summary>
	public Guid Id { get; set; }

	/// <summary>
	/// The username of the player playing as White.
	/// </summary>
	public string PlayerWhite { get; set; } = string.Empty;

	/// <summary>
	/// The username of the player playing as Black.
	/// </summary>
	public string PlayerBlack { get; set; } = string.Empty;

	/// <summary>
	/// A list of moves made during the game.
	/// </summary>
	public virtual List<Move> Moves { get; set; } = [];

	/// <summary>
	/// The result of the game: "WhiteWin", "BlackWin" or "Draw".
	/// </summary>
	public GameResult Result { get; set; }

	/// <summary>
	/// The date and time when the game began (in UTC).
	/// </summary>
	public DateTime Started { get; set; }

	/// <summary>
	/// The date and time when the game ended (in UTC).
	/// </summary>
	public DateTime Finished { get; set; } = DateTime.UtcNow;
}