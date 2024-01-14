using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Obvious.Soap;

public class ScriptableEventGameObjectInvoker : MonoBehaviour
{
    [SerializeField] private ScriptableEventGameObject _scriptableEvent;

    public void Raise(GameObject value)
    {
        _scriptableEvent.Raise(value);
    }
}
