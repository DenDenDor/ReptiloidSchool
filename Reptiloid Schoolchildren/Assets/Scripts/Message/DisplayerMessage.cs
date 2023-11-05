using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayerMessage : MonoBehaviour
{
    [SerializeField] private Message _message;
    [SerializeField] private Answer _answer;
    [SerializeField] private RequestCollection _requestCollection;
    private CreatorMessage _creatorMessage;

    public CreatorMessage CreatorMessage { get => _creatorMessage; private set => _creatorMessage = value; }

    private void Awake()
    {
        _creatorMessage = new CreatorMessage(transform, _message);
        _requestCollection.Activate();
        _creatorMessage.CreateMessage().WriteAnswer(_answer, _requestCollection.GetRequest(_answer));
        
    }
    
}
