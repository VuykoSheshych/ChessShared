namespace ChessShared.Models;
public class Move
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public int MoveNumber { get; set; }
	public string PlayerColor { get; set; } = string.Empty;
	public string From { get; set; } = string.Empty;
	public string To { get; set; } = string.Empty;
	public string? Promotion { get; set; } = string.Empty;
	public string SanNotation { get; set; } = string.Empty;
	public string FenBefore { get; set; } = string.Empty;
	public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}