using System;
using System.Collections.ObjectModel;
using System.Text;

namespace WiangtaiMemberApp.Model.Response;

public class BasicResponse
{
    private Collection<MessageResponse> _messages;

    public Collection<MessageResponse> MessageResponses
    {
        get { return this._messages ?? (this._messages = new Collection<MessageResponse>()); }
    }

    public bool IsError()
    {
        return this.MessageResponses.Count(item => item.Type == MessageResponse.MessageType.Error) > 0;
    }

    public bool IsContainInfo()
    {
        return this.MessageResponses.Count(item => item.Type == MessageResponse.MessageType.Info) > 0;
    }

    public string[] GetMessageResponseTextArray()
    {
        return this.MessageResponses.Select(item => item.Text).ToArray();
    }

    public string[] GetMessageResponseErrorTextArray()
    {
        return this.MessageResponses.Where(item => item.Type == MessageResponse.MessageType.Error).Select(item => item.Text).ToArray();
    }

    public string[] GetMessageResponseInfoTextArray()
    {
        return this.MessageResponses.Where(item => item.Type == MessageResponse.MessageType.Info).Select(item => item.Text).ToArray();
    }

    public string GetErrorMessageResponse()
    {
        var messageBuilder = new StringBuilder();
        foreach (var message in this.MessageResponses)
        {
            messageBuilder.AppendLine(message.Text);
        }

        return messageBuilder.ToString().Trim();
    }

    public void AddErrorMessageResponse(string errorMessageResponse)
    {
        this.MessageResponses.Add(new MessageResponse
        {
            Text = errorMessageResponse,
            Type = MessageResponse.MessageType.Error
        });
    }

    public void AddInfoMessageResponse(string infoMessageResponse)
    {
        this.MessageResponses.Add(new MessageResponse
        {
            Text = infoMessageResponse,
            Type = MessageResponse.MessageType.Info
        });
    }
}