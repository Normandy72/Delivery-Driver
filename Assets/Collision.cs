using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // collision action
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Oops!");
    }
    
    // actions when interacting with a trigger
    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("TRIGGER");
    }
}
