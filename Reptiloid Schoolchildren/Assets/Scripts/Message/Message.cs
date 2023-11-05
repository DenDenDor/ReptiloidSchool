using System.Collections;
using System;
using UnityEngine;
public class Message : MonoBehaviour
{
    public Answer Answer { get; private set; }
    public RequestCollection RequestCollection { get; private set; }
    public void WriteAnswer(Answer answer, IMessageRequest messageRequest)
    {
        if (answer == null)
        {
            throw new InvalidOperationException("Type is null!");
        }
        Answer = answer;
        Answer.AnswerHandler.SetMessageRequest(messageRequest);
        Answer.AnswerHandler.NextMove();
        Debug.Log("DICK");
    }
}
