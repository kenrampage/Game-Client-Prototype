using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Obvious.Soap;

public class ScriptableEventIntInvoker : MonoBehaviour
{
    [SerializeField] private ScriptableEventInt _scriptableEvent;

    public void Raise(int value)
    {
        _scriptableEvent.Raise(value);
    }
}
