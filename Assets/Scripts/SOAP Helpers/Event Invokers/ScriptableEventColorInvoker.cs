using Obvious.Soap;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableEventColorInvoker : MonoBehaviour
{
    [SerializeField] private ScriptableEventColor _scriptableEvent;

    public void Raise(Color value)
    {
        _scriptableEvent.Raise(value);
    }
}
