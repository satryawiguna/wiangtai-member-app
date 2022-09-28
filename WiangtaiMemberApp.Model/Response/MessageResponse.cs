using System;

namespace WiangtaiMemberApp.Model.Response;

public class MessageResponse
{
    public MessageType Type { get; set; }

    public string Text { get; set; }

    public enum MessageType
    {
        Error,
        Info,
        Warning
    }
}