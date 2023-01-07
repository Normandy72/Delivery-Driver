using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{   
     // SterializedField переносит переменную в Unity
    [SerializeField] float steerSpeed = 1f;  // если число целое, то f можно не писать

    [SerializeField] float moveSpeed = 0.01f;
    void Start()
    {
        
    }

    void Update()
    {
        // вращение по оси x, y, z
        transform.Rotate(0, 0, steerSpeed);

        // движение по оси x, y, z
        transform.Translate(0, moveSpeed, 0);
    }
}
