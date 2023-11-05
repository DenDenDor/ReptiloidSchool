using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Answer : ScriptableObject
{
    [SerializeField] private string _text;
    [SerializeField] private List<Answer> _answers;
    private AnswerHandler _answerHandler = new AnswerHandler();
    public abstract Color AnswerColor { get; }
    public string Text { get => _text; private set => _text = value; }
    public AnswerHandler AnswerHandler { get => _answerHandler; private set => _answerHandler = value; }
    public IReadOnlyList<Answer> Answers => _answers;

}
