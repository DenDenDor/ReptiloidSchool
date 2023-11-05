using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsistentMessageRequestFactory : RequestFactory
{
    [SerializeField] private DisplayerMessage _displayerMessage;
    protected override IMessageRequest SetMessageRequest() => new ConsistentMessageRequest(_displayerMessage.CreatorMessage, Answer);
}
