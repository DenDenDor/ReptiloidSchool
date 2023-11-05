using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MessageHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMeshProUGUI;
    [SerializeField] private Message _message;
    private void Start()
    {
        _textMeshProUGUI.text = _message.Answer.Text;
    }
}
