using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerDrop : MonoBehaviour
{
    public static int numPlayers;

    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;
    public GameObject prefab4;

    private void Start()
    {
        if(numPlayers == 1)
        {
            InstatiateObject(prefab1);
        }
        else if(numPlayers == 2)
        {
            InstatiateObject(prefab1);
            InstatiateObject(prefab2);
        }
        else if(numPlayers == 3)
        {
            InstatiateObject(prefab1);
            InstatiateObject(prefab2);
            InstatiateObject(prefab3);
        }
        else
        {
            InstatiateObject(prefab1);
            InstatiateObject(prefab2);
            InstatiateObject(prefab3);
            InstatiateObject(prefab4);
        }   
    }

    void InstatiateObject(GameObject prefab)
    {
        float randomX = Random.Range(-9, 9);
        float randomZ = Random.Range(-9, 9);

        Instantiate(prefab, new Vector3(randomX, 1.7f, randomZ), Quaternion.identity);
    }
}
