using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Obvious.Soap;
using Unity.VisualScripting;
using System;

[AddComponentMenu("Soap Helpers/EventValueListenerString")]
public class EventValueListenerString : MonoBehaviour
{
    [SerializeField] private ScriptableEventString _scriptableEvent;

    [SerializeField] private List<EventValueResponseString> _valueResponses;

    [Serializable]
    public class EventValueResponseString
    {
        public string Value;
        public UnityEvent Event;
    }

    private void OnEnable()
    {
        _scriptableEvent.OnRaised += ProcessValueResponses;
    }

    private void OnDisable()
    {
        _scriptableEvent.OnRaised -= ProcessValueResponses;
    }

    private void ProcessValueResponses(string value)
    {
        foreach (var response in _valueResponses)
        {
            if(response.Value == value)
            {
                response.Event?.Invoke();
            }
        }
    }
}
