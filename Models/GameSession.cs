using System;
using System.Collections.Generic;
using ChessShared.Dtos;

namespace ChessShared.Models;
public class GameSession
{
	public string Id { get; set; } = string.Empty;
	public required PlayerInGameDto WhitePlayer { get; set; }
	public required PlayerInGameDto BlackPlayer { get; set; }
	public List<Move> Moves { get; set; } = [];
	public List<ChatMessageDto> Messages { get; set; } = [];
	public string CurrentFen { get; set; } = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
	public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
