using System.Collections.Generic;

namespace ChessShared.Dtos;

public record SendNotificationRequest(string Sender, string Message, List<string> ReceiverIds);