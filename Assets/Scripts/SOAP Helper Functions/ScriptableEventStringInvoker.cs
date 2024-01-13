using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Obvious.Soap;

public class ScriptableEventStringInvoker : MonoBehaviour
{
    [SerializeField] private ScriptableEventString _scriptableEvent;

    public void Raise(string value)
    {
        _scriptableEvent.Raise(value);
    }
}
