using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformMechanics : MonoBehaviour
{
    public float timeRemaining;
    public int time;
    public bool timerIsRunning = false;

    public GameObject platform;

    public Text text;

    private void Start()
    {
        timeRemaining = Random.Range(1, 9);
        timerIsRunning = true;
    }

    void Update()
    {
        time = Mathf.FloorToInt(timeRemaining);
        text.text = time.ToString();

        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Invoke("ResetPlat", 1);
                platform.SetActive(false);
                timerIsRunning = false;
                timeRemaining = 0;
                text.enabled = false;
            }
        }
    }

    private void ResetPlat()
    {
        timeRemaining = Random.Range(1, 9);
        text.enabled = true;
        timerIsRunning = true;
        platform.SetActive(true);
    }
}
