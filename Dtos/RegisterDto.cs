namespace ChessShared.Dtos;

/// <summary>
/// Contains information required to register a new user.
/// </summary>
public record RegisterDto
{
	/// <summary>
	/// The username chosen by the user.
	/// </summary>
	public string UserName { get; init; } = string.Empty;

	/// <summary>
	/// The email address of the user.
	/// </summary>
	public string Email { get; init; } = string.Empty;

	/// <summary>
	/// The password for the user's account.
	/// </summary>
	public string Password { get; init; } = string.Empty;

	/// <summary>
	/// Initializes a new instance of the <see cref="RegisterDto"/> record.
	/// </summary>
	/// <param name="userName">The desired username.</param>
	/// <param name="email">The user's email address.</param>
	/// <param name="password">The account password.</param>
	public RegisterDto(string userName, string email, string password)
	{
		UserName = userName;
		Email = email;
		Password = password;
	}
}