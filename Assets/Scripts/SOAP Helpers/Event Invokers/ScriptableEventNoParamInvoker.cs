using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Obvious.Soap;

public class ScriptableEventNoParamInvoker : MonoBehaviour
{
    [SerializeField] private ScriptableEventNoParam _scriptableEvent;

    public void Raise()
    {
        _scriptableEvent.Raise();
    }
}
