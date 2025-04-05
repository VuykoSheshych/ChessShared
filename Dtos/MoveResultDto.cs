namespace ChessShared.Dtos;

public record MoveResultDto(bool IsSuccess, string Message)
{
	public static MoveResultDto Success(string message) => new(true, message);
	public static MoveResultDto Error(string message) => new(false, message);
}