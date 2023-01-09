using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    // collision action
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Oops!");
    }
    
    // actions when interacting with a trigger
    void OnTriggerEnter2D(Collider2D other) 
    {
        // Debug.Log("TRIGGER");

        // if the thing we trigger is a package
        // {
        //      then print "package picked up" to the console
        // }

        if(other.tag == "Package")
        {
            Debug.Log("Package picked up!");
        }

        if(other.tag == "Customer")
        {
            Debug.Log("delivered package");
        }
    }
}
