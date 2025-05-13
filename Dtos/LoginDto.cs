namespace ChessShared.Dtos;

/// <summary>
/// Contains the credentials required to authenticate a user.
/// </summary>
public record LoginDto
{
	/// <summary>
	/// The user's username.
	/// </summary>
	public string UserName { get; init; } = string.Empty;

	/// <summary>
	/// The user's password.
	/// </summary>
	public string Password { get; init; } = string.Empty;

	/// <summary>
	/// Initializes a new instance of the <see cref="LoginDto"/> record.
	/// </summary>
	/// <param name="userName">The user's username.</param>
	/// <param name="password">The user's password.</param>
	public LoginDto(string userName, string password)
	{
		UserName = userName;
		Password = password;
	}
}