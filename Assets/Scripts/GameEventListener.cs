// Component to listen to global game events
// Alex Kisil
// https://unity.com/how-to/architect-game-code-scriptable-objects
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    public GameEvent Event;
    public UnityEvent Response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);    
    }

    public void OnEventRaised()
    {
        Response.Invoke();
    }
}
