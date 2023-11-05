using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "StudentAnswer", menuName = "ScriptableObjects/Answer/StudentAnswer")]

public class StudentAnswer : Answer
{
    public override Color AnswerColor => Color.red;

}
