using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutToggle : MonoBehaviour
{
    public GameObject step1;
    public GameObject step2;

    public void ChangeStep()
    {
        step1.SetActive(false);
        step2.SetActive(true);
    }
}
