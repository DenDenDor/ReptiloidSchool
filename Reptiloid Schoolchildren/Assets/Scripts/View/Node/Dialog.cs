using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class Dialog : Node {

	[SerializeField] private string _name;
	[SerializeField] [TextArea(5,10)] private string _text;
    [SerializeField] private ChoiseElement[] _choiseElements;
    public string Name { get => _name; private set => _name = value; }
    public string Text { get => _text; private set => _text = value; }

    [System.Serializable]
    public class ChoiseElement
    {
        [SerializeField] private string _text;
        [SerializeField] private Dialogs _dialogs;
        public string Text { get => _text; private set => _text = value; }
        public Dialogs Dialogs { get => _dialogs; private set => _dialogs = value; }
    }
    [SerializeField] private Dialog[] _dialogs;
    public Dialog[] Get { get => _dialogs; private set => _dialogs = value; }
    public ChoiseElement[] ChoiseElements { get => _choiseElements; private set => _choiseElements = value; }
}