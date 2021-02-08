using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public InputMaster controls;

    void Awake() 
    {
        //controls.Player.Interact.performed += 
    }

    public void OnInteract()
    {
        Debug.Log("Player: Interact.");
    }
}
