using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerNumManagerCountdown : MonoBehaviour
{
    public int gameNum;

    private void Update()
    {
        gameNum = LoadScenes.gameNum;
    }

    public void P1()
    {
        SpawnManagerCountdown.numPlayers += 1;
        SceneManager.LoadScene(GameDictionary.gameNums[gameNum]);
    }
    public void P2()
    {
        SpawnManagerCountdown.numPlayers += 2;
        SceneManager.LoadScene(GameDictionary.gameNums[gameNum]);
    }
    public void P3()
    {
        SpawnManagerCountdown.numPlayers += 3;
        SceneManager.LoadScene(GameDictionary.gameNums[gameNum]);
    }
    public void P4()
    {
        SpawnManagerCountdown.numPlayers += 4;
        SceneManager.LoadScene(GameDictionary.gameNums[gameNum]);
    }
}
