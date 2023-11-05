using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorMessage 
{
    private readonly Message _message;
    private readonly Transform _parent;

    private IMessageRequest _messageRequest;
    public Message CreatedMessage { get; private set; }

    public CreatorMessage(Transform parent, Message message)
    {
        _parent = parent;
        _message = message;
       // SetMessageRequest(requestCollection);
    }
    private void SetMessageRequest(RequestCollection requestCollection)
    {
        if (requestCollection == null)
        {
            throw new System.InvalidOperationException("You set a null message request!");
        }
       // _messageRequest = requestCollection.GetRequest();
    }
    public Message CreateMessage()
    {
        CreatedMessage = MonoBehaviour.Instantiate(_message);
        CreatedMessage.transform.SetParent(_parent);
       // CreatedMessage.Answer.AnswerHandler.SetMessageRequest(_messageRequest);
        return CreatedMessage;
    }
}
