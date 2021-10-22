using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    //get a reference to rigidbody
    Rigidbody rb;

    public Vector3 dir;

    public bool isGrounded = false;

    int coins = 0;

    public Vector3 startPosition;

    public int resetPoint;

    public int SceneActive = 0;


    [Tooltip("Speed multiplier for Horizontal and Vertical movement.")]
    [Range(5f,50f)]           // adds a slider for speed instead of number input
    public float speed = 10, jumpForce = 5;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }


    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        startPosition = GameObject.Find("StartPos").transform.position;
        
        //this.transform.position = startPosition;
        //rb.velocity = Vector3.zero;
        //rb.angularVelocity = Vector3.zero;
    }

    void Update()
    {
        if(this.transform.position.y < resetPoint)
        {
            if(SceneActive == 1)
            {
                SetPlayer();
            }           
            else
            {
                ResetPlayer(); 
            }
        }
    }

    void FixedUpdate()
    {
        dir.y = 0;
        rb.AddForce(dir * speed);
        
        //if(this.transform.position.y < -5)
        //{
        //    ResetPlayer();
        //}
    }

    //void ResetPlayer()
    //{
    //    this.transform.position = startPosition;
    //}

    public void Jump()
    {
        if(isGrounded)
        {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void ResetPlayer()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void SetPlayer()
    {
        this.transform.position = startPosition;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Floor"))
        {
            isGrounded = true;
        }

        if(other.gameObject.CompareTag("Hole"))
        {
            isGrounded = false;
        }

        if(other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
        }
    }

        void OnTriggerExit(Collider other)
        {
            if(other.gameObject.CompareTag("Floor"))
            {
                isGrounded = false;
            }
        }

    //create a function to move
    //public void MoveHorizontal(float force)
    //{
    //    rb.AddForce(force * speed, 0, 0);
    //}
    //public void MoveVertical(float force)
    //{
    //    rb.AddForce(0, 0, force * speed);
    //}
}
