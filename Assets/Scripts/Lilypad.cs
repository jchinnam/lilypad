using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lilypad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Spawn a circle collider that expands as part of a coroutine, causing any other "interactable"
    // objects to pulse if they are touched by the collider. This function should not call Pulse() on 
    // other objects, but rather simply raise an event upon collision so that functionality is flexible.
    // Pulse() itself should be called upon a mouseclick event within the bounds of the .
    private void Pulse(){
        CircleCollider2D pulseCollider = gameObject.AddComponent<CircleCollider2D>();
    }

    // On a mouse click event, this function should check if this gameObject is the object being clicked,
    // raising an event if so.
    private void CheckIfClicked(){

    }


}
