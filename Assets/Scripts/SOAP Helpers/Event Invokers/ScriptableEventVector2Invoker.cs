using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Obvious.Soap;

public class ScriptableEventVector2Invoker : MonoBehaviour
{
    [SerializeField] private ScriptableEventVector2 _scriptableEvent;

    public void Raise(Vector2 value)
    {
        _scriptableEvent.Raise(value);
    }
}