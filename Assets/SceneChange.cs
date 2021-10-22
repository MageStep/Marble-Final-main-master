using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("EndScene"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            PlayerMovement player = GameObject.Find("Icosphere").GetComponent<PlayerMovement>();
            player.startPosition = GameObject.Find("StartPos").transform.position;
            player.SetPlayer();
            player.SceneActive++;
        }
    }
}
