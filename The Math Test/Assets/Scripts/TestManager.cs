using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    public GameObject[] Levels;
    public GameObject[] Fails;
    public GameObject classLights;

    int currentLevel;
    int incorrect;

    public void correctAnswer()
    {
        if(currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);

            currentLevel++;
            Levels[currentLevel].SetActive(true);
        }
    }

    public void wrongAnswer()
    {
        if(incorrect + 1 != Fails.Length)
        {
            classLights.SetActive(false);
        }
    }
}
