using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIntro : MonoBehaviour
{
    public GameObject canvas;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("walked through");
        Destroy(canvas);
    }
}
