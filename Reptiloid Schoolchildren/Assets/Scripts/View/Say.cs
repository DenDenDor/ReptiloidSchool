using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using XNode;

public class Say : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private NodeGraph _dialogs;
    private int _index;
    private void Start()
    {
        if (_dialogs != null)
        {
            NextDialog();
        }
    }
    public void NextDialog()
    {
        if (_index == _dialogs.nodes.Count)
        {
            return;
        }
        switch (_dialogs.nodes[_index])
        {
            case Dialog dialog:
                _name.SetText(dialog.Name);
                _text.SetText(dialog.Text);
                break;
        }
        _index++;
    }
    public void Choose(ChoiseButton choiseButton)
    {

    }
}
