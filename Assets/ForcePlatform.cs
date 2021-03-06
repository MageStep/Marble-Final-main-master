using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcePlatform : MonoBehaviour
{
    public float force = 20f;
    public bool zeroOutVelocity = false;
    public bool singleUse = false;
 
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            //stop the player's movement
            if(zeroOutVelocity) rb.velocity = Vector3.zero;
            // push the player UP relative to the direction of the platform
            rb.AddForce(this.transform.up * force, ForceMode.Impulse);
            // destroy this after use
            if(singleUse) Destroy(this.gameObject);
        }
    }
}
