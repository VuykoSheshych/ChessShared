#nullable enable

using ChessShared.Enums;

namespace ChessShared.Dtos;

/// <summary>
/// Represents a chess move made by a player.
/// </summary>
public record MoveDto
{
	/// <summary>
	/// The square the piece moved from (e.g., "e2").
	/// </summary>
	public string From { get; init; } = string.Empty;

	/// <summary>
	/// The square the piece moved to (e.g., "e4").
	/// </summary>
	public string To { get; init; } = string.Empty;

	/// <summary>
	/// The type of piece the pawn is promoted to, if applicable.
	/// </summary>
	public PromotionPieceType? Promotion { get; init; }

	/// <summary>
	/// Initializes a new instance of the <see cref="MoveDto"/> record with the specified move details.
	/// </summary>
	/// <param name="from">The square the piece moved from.</param>
	/// <param name="to">The square the piece moved to.</param>
	/// <param name="promotion">The promotion piece type, if applicable.</param>
	public MoveDto(string from, string to, PromotionPieceType? promotion = null)
	{
		From = from;
		To = to;
		Promotion = promotion;
	}
}