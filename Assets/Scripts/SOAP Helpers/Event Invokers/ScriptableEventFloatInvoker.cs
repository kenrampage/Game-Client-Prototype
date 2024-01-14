using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Obvious.Soap;

public class ScriptableEventFloatInvoker : MonoBehaviour
{
    [SerializeField] private ScriptableEventFloat _scriptableEvent;

    public void Raise(float value)
    {
        _scriptableEvent.Raise(value);
    }
}
