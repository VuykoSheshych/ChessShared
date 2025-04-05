using System;

namespace ChessShared.Dtos;

public record MarkAsReadRequest(string UserId, Guid NotificationId);