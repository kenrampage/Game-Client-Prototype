using Obvious.Soap;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableEventBoolInvoker : MonoBehaviour
{
    [SerializeField] private ScriptableEventBool _scriptableEvent;

    public void Raise(bool value)
    {
        _scriptableEvent.Raise(value);
    }
}
