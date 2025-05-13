using System.Collections.Generic;

namespace ChessShared.Models;

/// <summary>
/// Represents the current authenticated user, including basic identity and claims information.
/// </summary>
public class CurrentUser
{
	/// <summary>
	/// Indicates whether the user is authenticated.
	/// </summary>
	public bool IsAuthenticated { get; set; }

	/// <summary>
	/// The username of the authenticated user.
	/// </summary>
	public string UserName { get; set; } = string.Empty;

	/// <summary>
	/// A dictionary of claims associated with the user, where the key is the claim type and the value is the claim value.
	/// </summary>
	public Dictionary<string, string> Claims { get; set; } = [];
}