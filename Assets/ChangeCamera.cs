using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("CameraChange"))
        {
            cam2.SetActive(true);
            cam1.SetActive(false);
        }
    }
}
