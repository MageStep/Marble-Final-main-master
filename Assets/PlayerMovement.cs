using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    //get a reference to rigidbody
    Rigidbody rb;

    [Tooltip("Speed multiplier for Horizontal and Vertical movement.")]
    [Range(5f,50f)]           // adds a slider for speed instead of number input
    public float speed = 10;


    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    //create a function to move
    public void MoveHorizontal(float force)
    {
        rb.AddForce(force * speed, 0, 0);
    }

    public void MoveVertical(float force)
    {
        rb.AddForce(0, 0, force * speed);
    }
}
