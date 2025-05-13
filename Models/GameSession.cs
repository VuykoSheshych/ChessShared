using System;
using System.Collections.Generic;
using ChessShared.Dtos;

namespace ChessShared.Models;

/// <summary>
/// Represents a session of a chess game, including players, moves, chat messages and the current game state (FEN).
/// </summary>
public class GameSession
{
	/// <summary>
	/// The unique identifier for the game session.
	/// </summary>
	public Guid Id { get; set; } = Guid.NewGuid();

	/// <summary>
	/// The details of the player playing as White.
	/// </summary>
	public required PlayerInGameDto WhitePlayer { get; set; }

	/// <summary>
	/// The details of the player playing as Black.
	/// </summary>
	public required PlayerInGameDto BlackPlayer { get; set; }

	/// <summary>
	/// A list of moves made during the game.
	/// </summary>
	public List<Move> Moves { get; set; } = [];

	/// <summary>
	/// A list of chat messages sent during the game.
	/// </summary>
	public List<ChatMessageDto> Messages { get; set; } = [];

	/// <summary>
	/// The current FEN (Forsyth-Edwards Notation) string representing the state of the chessboard.
	/// </summary>
	public string CurrentFen { get; set; } = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";

	/// <summary>
	/// The date and time when the game session was created.
	/// </summary>
	public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
