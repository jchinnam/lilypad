using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public InputMaster controls;
    
    [SerializeField]
    public float selectionRadius = .1f;

    void Awake() 
    {
        
    }

    void Start(){

    }

    void Update(){
        
    }

    public void OnInteract()
    {
        Vector2 mousePos = Camera.main.ScreenToViewportPoint(Mouse.current.position.ReadValue());
        Debug.Log("Player: Interact at: " + mousePos);

    }
}
