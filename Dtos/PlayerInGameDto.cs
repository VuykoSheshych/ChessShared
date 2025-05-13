using System;

namespace ChessShared.Dtos;

/// <summary>
/// Represents a player in an ongoing chess game session.
/// </summary>
public record PlayerInGameDto
{
	/// <summary>
	/// The player's display name.
	/// </summary>
	public string Name { get; init; } = string.Empty;

	/// <summary>
	/// The SignalR connection ID associated with the player.
	/// </summary>
	public string ConnectionId { get; init; } = string.Empty;

	/// <summary>
	/// The remaining time the player has in the game, if time control is enabled.
	/// </summary>
	public TimeSpan? TimeReserve { get; init; } = null;

	/// <summary>
	/// Initializes a new instance of the <see cref="PlayerInGameDto"/> record.
	/// </summary>
	/// <param name="name">The player's name.</param>
	/// <param name="connectionId">The SignalR connection ID.</param>
	/// <param name="timeReserve">The player's remaining time, if applicable.</param>
	public PlayerInGameDto(string name, string connectionId, TimeSpan? timeReserve = null)
	{
		Name = name;
		ConnectionId = connectionId;
		TimeReserve = timeReserve;
	}
}