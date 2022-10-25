using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    public GameObject[] Levels;
    public GameObject[] Fails;
    public GameObject classLights;
    public GameObject computerLight;
    public GameObject door;
    public GameObject blood;

    public AudioSource lightHum;
    public AudioSource lightOff;
    public AudioSource normalBGM;
    public AudioSource distortedBGM;
    public AudioSource computerStart;
    public AudioSource doorCreak;
    public AudioSource darkBGM;

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
        switch (incorrect)
        {
            case 0:
                lightHum.Stop();
                lightOff.Play();
                classLights.SetActive(false);
                break;

            case 1:
                normalBGM.Stop();
                distortedBGM.Play();
                break;

            case 2:
                computerStart.Play();
                computerLight.SetActive(true);
                break;

            case 3:
                Destroy(door);
                doorCreak.Play();
                break;

            case 4:
                distortedBGM.Stop();
                darkBGM.Play();
                blood.SetActive(true);
                break;

        }

        if (currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);

            currentLevel++;
            Levels[currentLevel].SetActive(true);
        }

        incorrect++;
    }
}
