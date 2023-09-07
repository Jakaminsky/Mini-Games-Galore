using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    public static int gameNum = 0;

    public float timeRemaining = 7;
    public int time;
    public bool timerIsRunning = false;

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                time = Mathf.FloorToInt(timeRemaining);
                if(time == 4)
                {
                    DollyMovement.speed = 6.5f;
                }
                if (time == 2)
                {
                    DollyMovement.speed = 8f;
                }
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                SceneManager.LoadScene("GameList");
            }
        }
    }

    public void LoadList()
    {
        timerIsRunning = true;
        DollyMovement.speed = 5f;
    }

    public void LoadDropGame()
    {
        gameNum = 0;
        SceneManager.LoadScene("PlayersSelectDrop");
    }
    public void LoadMashGame()
    {
        gameNum = 1;
        SceneManager.LoadScene("PlayersSelectMash");
    }
    public void LoadFinalCountdown()
    {
        gameNum = 2;
        SceneManager.LoadScene("PlayersSelectCountdown");
    }
}
