using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ConsistentMessageRequest : IMessageRequest
{
    private readonly CreatorMessage _creatorMessage;
    private readonly Answer _answer;
    public ConsistentMessageRequest(CreatorMessage creatorMessage, Answer answer)
    {
        
        _creatorMessage = creatorMessage;
        _answer = answer;
    }
    public void MakeRequest()
    {
        Debug.Log(_answer + " LOL! " + _creatorMessage + "!");
        Answer answer = _creatorMessage.CreatedMessage.Answer;
        if (answer.Answers.Count != 0)
        {
            Answer nextAnswer = answer.Answers.FirstOrDefault();
            if (nextAnswer is TeacherAnswer)
            {
                //nextAnswer.AnswerHandler.SetMessageRequest(messageRequest);
            }
            _creatorMessage.CreateMessage().WriteAnswer(nextAnswer, this);
        }
    }
}
