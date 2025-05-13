namespace ChessShared.Models;

/// <summary>
/// Represents the configuration options used for generating and validating JSON Web Tokens (JWT).
/// </summary>
public class JwtOptions
{
	/// <summary>
	/// The issuer (iss) claim that identifies the principal that issued the JWT.
	/// </summary>
	public string Issuer { get; set; } = string.Empty;

	/// <summary>
	/// The audience (aud) claim that identifies the recipients that the JWT is intended for.
	/// </summary>
	public string Audience { get; set; } = string.Empty;

	/// <summary>
	/// The secret key used to sign the JWT. Must be a sufficiently long and random string.
	/// </summary>
	public string Secret { get; set; } = string.Empty;

	/// <summary>
	/// The expiration time (in minutes) for the generated JWT.
	/// </summary>
	public int ExpirationMinutes { get; set; } = 60;
}