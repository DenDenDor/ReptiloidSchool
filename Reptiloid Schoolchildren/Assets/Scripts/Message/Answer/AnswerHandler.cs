using System;
using System.Collections.Generic;
using UnityEngine;

public class AnswerHandler
{
    private IMessageRequest _messageRequest;
    public void SetMessageRequest(IMessageRequest messageRequest)
    {
        _messageRequest = messageRequest;
    }

    public void NextMove()
    {
        if (_messageRequest == null)
        {
            throw new InvalidOperationException("Message Request is not setup!");
        }
        _messageRequest.MakeRequest();
    }
}
