using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject camOne;
    public GameObject camTwo;
    private bool camState;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (camState)
            {
                camOne.SetActive(true);
                camTwo.SetActive(false);
                camState = false;
            }
            else
            {
                camOne.SetActive(false);
                camTwo.SetActive(true);
                camState = true;
            }
        }
    }
}