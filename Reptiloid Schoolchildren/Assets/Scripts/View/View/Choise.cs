using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choise : MonoBehaviour
{
    [SerializeField] private Canvas _self;
    public void Show() => _self.enabled = true;
    public void Hide() => _self.enabled = false;

}
