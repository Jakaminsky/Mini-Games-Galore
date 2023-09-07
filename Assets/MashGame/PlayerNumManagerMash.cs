using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerNumManagerMash : MonoBehaviour
{
    public int gameNum;

    private void Update()
    {
        gameNum = LoadScenes.gameNum;
    }

    public void P1()
    {
        SpawnManagerMash.numPlayers += 1;
        SceneManager.LoadScene(GameDictionary.gameNums[gameNum]);
    }
    public void P2()
    {
        SpawnManagerMash.numPlayers += 2;
        SceneManager.LoadScene(GameDictionary.gameNums[gameNum]);
    }
    public void P3()
    {
        SpawnManagerMash.numPlayers += 3;
        SceneManager.LoadScene(GameDictionary.gameNums[gameNum]);
    }
    public void P4()
    {
        SpawnManagerMash.numPlayers += 4;
        SceneManager.LoadScene(GameDictionary.gameNums[gameNum]);
    }
}
