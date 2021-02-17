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
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //Debug.Log("Player: Interact at: " + mousePos);
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(mousePos, selectionRadius);

        int i = 0;
        foreach (Collider2D col in hitColliders){
            Debug.Log("Hitting collider: " + i);
            ++i;
        }
    }
}
