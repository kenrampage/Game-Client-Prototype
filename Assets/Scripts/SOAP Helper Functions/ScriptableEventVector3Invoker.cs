using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Obvious.Soap;

public class ScriptableEventVector3Invoker : MonoBehaviour
{
    [SerializeField] private ScriptableEventVector3 _scriptableEvent;

    public void Raise(Vector3 value)
    {
        _scriptableEvent.Raise(value);
    }
}
