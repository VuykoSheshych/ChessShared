using System.Collections.Generic;

namespace ChessShared.Models;

public class CurrentUser
{
	public bool IsAuthenticated { get; set; }
	public string UserName { get; set; } = string.Empty;
	public Dictionary<string, string> Claims { get; set; } = [];
}