using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerNumManagerDrop : MonoBehaviour
{
    public int gameNum;

    private void Update()
    {
        gameNum = LoadScenes.gameNum;
    }

    public void P1()
    {
        SpawnManagerDrop.numPlayers += 1;
        SceneManager.LoadScene(GameDictionary.gameNums[gameNum]);
    }
    public void P2()
    {
        SpawnManagerDrop.numPlayers += 2;
        SceneManager.LoadScene(GameDictionary.gameNums[gameNum]);
    }
    public void P3()
    {
        SpawnManagerDrop.numPlayers += 3;
        SceneManager.LoadScene(GameDictionary.gameNums[gameNum]);
    }
    public void P4()
    {
        SpawnManagerDrop.numPlayers += 4;
        SceneManager.LoadScene(GameDictionary.gameNums[gameNum]);
    }
}
