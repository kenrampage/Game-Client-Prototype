using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InvokeUnityEvent : MonoBehaviour
{
    public UnityEvent Event;
    public bool InvokeOnStart = false;
    public void InvokeEvent()
    {
        Event?.Invoke();
    }

    private void Start()
    {
        if(InvokeOnStart)
        {
            InvokeEvent();
        }
    }
}
