#nullable enable
using System;
using ChessShared.Enums;

namespace ChessShared.Models;

/// <summary>
///Represents a move made by a player during a chess game, including the move's details, notation, and timestamp.
/// </summary>
public class Move
{
	/// <summary>
	/// The unique identifier for the move.
	/// </summary>
	public Guid Id { get; set; } = Guid.NewGuid();

	/// <summary>
	/// The full move number in the game (e.g., "1" for the first white move `e4`, "1" for the first black move `e5`, "2" for the second white move `f4`, etc.).
	/// </summary>
	public int MoveNumber { get; set; }

	/// <summary>
	/// The color of the player who made the move: "Black" or "White".
	/// </summary>
	public PlayerColor PlayerColor { get; set; }

	/// <summary>
	/// The starting position of the piece being moved, in chess notation (e.g., "e2").
	/// </summary>
	public string From { get; set; } = string.Empty;

	/// <summary>
	/// The destination position of the piece, in chess notation (e.g., "e4").
	/// </summary>
	public string To { get; set; } = string.Empty;

	/// <summary>
	/// Optional. The piece the pawn is promoted to, if the move is a pawn promotion.
	/// </summary>
	public PromotionPieceType? Promotion { get; set; }

	/// <summary>
	/// The move in Standard Algebraic Notation (SAN), used to represent the move in chess notation (e.g., "Bxc5+", "Nf3").
	/// </summary>
	public string SanNotation { get; set; } = string.Empty;

	/// <summary>
	/// The FEN string representing the state of the board before the move was made.
	/// </summary>
	public string FenBefore { get; set; } = string.Empty;

	/// <summary>
	/// The date and time when the move was made.
	/// </summary>
	public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}