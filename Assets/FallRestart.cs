using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallRestart : MonoBehaviour
{

    public int resetPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y < resetPoint)
        {
            SceneManager.LoadScene("Level 1");
        }
    }
}
