using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallRestart : MonoBehaviour
{

    PlayerMovement player;

    public int resetPoint;
    // Start is called before the first frame update
    void Start()
    {
        player = this.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y < resetPoint)
        {
            player.coins = 0;
            SceneManager.LoadScene("Level 1");
        
        }
    }
}
