using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerMash : MonoBehaviour
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
            InstatiateObject(prefab1, -4.0f);
        }
        else if(numPlayers == 2)
        {
            InstatiateObject(prefab1, -4.0f);
            InstatiateObject(prefab2, 0);
        }
        else if(numPlayers == 3)
        {
            InstatiateObject(prefab1, -4.0f);
            InstatiateObject(prefab2, 0);
            InstatiateObject(prefab3, 5.4f);
        }
        else
        {
            InstatiateObject(prefab1, -4.0f);
            InstatiateObject(prefab2, 0);
            InstatiateObject(prefab3, 5.4f);
            InstatiateObject(prefab4, 10);
        }   
    }

    void InstatiateObject(GameObject prefab, float z)
    {
        Instantiate(prefab, new Vector3(2, -1.2f, z), Quaternion.identity);
    }
}
