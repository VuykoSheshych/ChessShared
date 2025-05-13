namespace ChessShared.Dtos;

/// <summary>
/// Represents the result of a move attempt in a chess game.
/// </summary>
public record MoveResultDto(bool IsSuccess, string Message)
{
	/// <summary>
	/// Indicates whether the move was successful.
	/// </summary>
	public bool IsSuccess { get; init; } = IsSuccess;

	/// <summary>
	/// A descriptive message explaining the result.
	/// </summary>
	public string Message { get; init; } = Message;

	/// <summary>
	/// Creates a successful move result.
	/// </summary>
	/// <param name="message">The success message.</param>
	/// <returns>A new instance of <see cref="MoveResultDto"/> indicating success.</returns>
	public static MoveResultDto Success(string message) => new(true, message);

	/// <summary>
	/// Creates a failed move result.
	/// </summary>
	/// <param name="message">The error message.</param>
	/// <returns>A new instance of <see cref="MoveResultDto"/> indicating failure.</returns>
	public static MoveResultDto Error(string message) => new(false, message);
}