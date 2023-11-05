using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChoiseButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Button _self;
    [SerializeField] private Say _say;
    public Dialog Dialog { get; set; }
    public void Set(Dialog.ChoiseElement choiseElement)
    {
       // Dialog = choiseElement.Dialogs;
        _self.onClick.AddListener(() => _say.Choose(this));
    }
}
