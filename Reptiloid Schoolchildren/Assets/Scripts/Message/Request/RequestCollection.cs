using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequestCollection : MonoBehaviour
{
    [SerializeField] private List<RequestFactory> _requestFactories;
    public void Activate()
    {
        _requestFactories.ForEach(e => e.CreateRequest());
    }
    public IMessageRequest GetRequest(Answer answer) => _requestFactories.Find(e => e.Answer.GetType() == answer.GetType()).MessageRequest;
    
}
