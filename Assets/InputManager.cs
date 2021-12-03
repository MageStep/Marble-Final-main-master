using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    //get a reference to the PlayerMovement script
    public PlayerMovement player;

    public bool paused = false;

    public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        if(player == null)
        {
            player = GameObject.Find("Sphere").GetComponent<PlayerMovement>();
        }

        if(pauseMenu == null) pauseMenu = GameObject.Find("PauseMenu");
    }

    void PauseGame()
    {

        paused = !paused;
        if(paused)
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
        else 
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }

        if(Input.GetKey(KeyCode.LeftControl))
        {
            if(Input.GetKeyDown(KeyCode.Q))
            {
                Application.Quit();
                
            }
        }


        //call movement every frame and send it axis data.
        player.dir.x = Input.GetAxis("Horizontal") * 3;
        player.dir.z = Input.GetAxis("Vertical") * 3;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            player.Jump();
        }

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            player.Dash();
        }



        //if(Input.GetKeyDown(KeyCode.F5))
        //{
        //    PlayerPrefs.SetInt("canJump", 0);
        //}
    }
}
