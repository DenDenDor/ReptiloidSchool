using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RequestFactory : MonoBehaviour
{
    [SerializeField] private Answer _answer;
    public IMessageRequest MessageRequest { get; private set; }
    public Answer Answer { get => _answer; private set => _answer = value; }

    public void CreateRequest()
    {
        MessageRequest = SetMessageRequest();
    }
    protected abstract IMessageRequest SetMessageRequest();
}
