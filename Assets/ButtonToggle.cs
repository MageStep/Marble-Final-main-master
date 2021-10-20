using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonToggle : MonoBehaviour
{
    public GameObject redWall;
    public GameObject canvas;

    public AudioSource aud;

    public AudioClip ding;

    private TutToggle tuts;

    void Start()
    {
        tuts = canvas.GetComponent<TutToggle>();
    }


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Button"))
        {
        Destroy(redWall);
        aud.PlayOneShot(ding);
        tuts.ChangeStep();
        }
    }
}
