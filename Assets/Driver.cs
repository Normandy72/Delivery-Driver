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
        // движение по оси x (steerAmount) и y (moveAmount)
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        // вращение по оси x, y, z
        transform.Rotate(0, 0, -steerAmount);

        // движение по оси x, y, z
        transform.Translate(0, moveAmount, 0);
    }
}
