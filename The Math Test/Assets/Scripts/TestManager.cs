using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestManager : MonoBehaviour
{
    public GameObject[] Levels;
    public GameObject[] Fails;
    public GameObject classLights;
    public GameObject computerLight;
    public GameObject door;
    public GameObject blood;
    public GameObject monster;
    public GameObject monster2;

    public GameObject tip1;
    public GameObject tip2;
    public GameObject tip3;

    public AudioSource lightHum;
    public AudioSource lightOff;
    public AudioSource normalBGM;
    public AudioSource distortedBGM;
    public AudioSource computerStart;
    public AudioSource doorCreak;
    public AudioSource darkBGM;
    public AudioSource monsterBreath;
    public AudioSource monsterSound;
    public AudioSource monsterScream;

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
                tip1.SetActive(false);
                tip2.SetActive(true);
                break;

            case 1:
                normalBGM.Stop();
                distortedBGM.Play();
                break;

            case 2:
                computerStart.Play();
                computerLight.SetActive(true);
                tip2.SetActive(false);
                tip3.SetActive(true);
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

            case 5:
                monster.SetActive(true);
                monsterBreath.Play();
                break;

            case 6:
                monster.SetActive(false);
                monster2.SetActive(true);
                monsterSound.Play();
                break;

            case 7:
                monsterScream.Play(5);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
