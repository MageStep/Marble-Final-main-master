using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    //get a reference to the PlayerMovement script
    public PlayerMovement player;

    // Start is called before the first frame update
    void Start()
    {
        if(player == null)
        {
            player = GameObject.Find("Icosphere").GetComponent<PlayerMovement>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //call movement every frame and send it axis data.
        player.dir.x = Input.GetAxis("Horizontal") * 3;
        player.dir.z = Input.GetAxis("Vertical") * 3;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            player.Jump();
        }
    }
}
