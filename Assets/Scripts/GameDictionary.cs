using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDictionary : MonoBehaviour
{
    public static IDictionary<int, string> gameNums = new Dictionary<int, string>();

    void Start()
    {
        gameNums.Add(0, "DropGame");
        gameNums.Add(1, "MashGame");
        gameNums.Add(2, "Final_Countdown");
    }

    public void PrintGameList()
    {
        foreach (KeyValuePair<int, string> kvp in gameNums)
            Debug.Log("Key: {0}, Value: {1} " + kvp.Key + ": " + kvp.Value);
    }
}
