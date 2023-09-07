using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class MashMechanics : MonoBehaviour
{
    public int counter1 = 0;
    public int counter2 = 0;
    public int counter3 = 0;
    public int counter4 = 0;

    public static float timeRemaining = 15.5f;
    public int time = Mathf.FloorToInt(timeRemaining);
    public bool timerIsRunning = false;

    public Text timer;

    public GameObject prefab;

    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;

    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;

    int numPlayers;

    private void Start()
    {
        timerIsRunning = true;
    }
    private void Update()
    {
        numPlayers = SpawnManagerMash.numPlayers;

        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                time = Mathf.FloorToInt(timeRemaining);
                timer.text = time.ToString();
                if (Input.GetKeyDown(KeyCode.W))
                {
                    counter1++;
                }
                if (Input.GetKeyDown(KeyCode.T))
                {
                    counter2++;
                }
                if (Input.GetKeyDown(KeyCode.I))
                {
                    counter3++;
                }
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    counter4++;
                }
            }
            else
            {
                timer.enabled = false;
                timeRemaining = 0;
                timerIsRunning = false;
                shootMash();
            }
        }

        s1.transform.localScale = new Vector3(1 * (counter1 * 0.05f), 1 * (counter1 * 0.05f), 1 * (counter1 * 0.05f));
        s2.transform.localScale = new Vector3(1 * (counter2 * 0.05f), 1 * (counter2 * 0.05f), 1 * (counter2 * 0.05f));
        s3.transform.localScale = new Vector3(1 * (counter3 * 0.05f), 1 * (counter3 * 0.05f), 1 * (counter3 * 0.05f));
        s4.transform.localScale = new Vector3(1 * (counter4 * 0.05f), 1 * (counter4 * 0.05f), 1 * (counter4 * 0.05f));

    }

    public void shootMash()
    {
        if (numPlayers == 1)
        {
            InstatiateObject(p1, counter1);
            s1.SetActive(false);
        }
        else if (numPlayers == 2)
        {
            InstatiateObject(p1, counter1);
            InstatiateObject(p2, counter2);
            s1.SetActive(false);
            s2.SetActive(false);

        }
        else if (numPlayers == 3)
        {
            InstatiateObject(p1, counter1);
            InstatiateObject(p2, counter2);
            InstatiateObject(p3, counter3);
            s1.SetActive(false);
            s2.SetActive(false);
            s3.SetActive(false);

        }
        else
        {
            InstatiateObject(p1, counter1);
            InstatiateObject(p2, counter2);
            InstatiateObject(p3, counter3);
            InstatiateObject(p4, counter4);
            s1.SetActive(false);
            s2.SetActive(false);
            s3.SetActive(false);
            s4.SetActive(false);
        }
    }

    public void InstatiateObject(GameObject gameObject, int counter)
    {
        var instance = Instantiate(prefab, gameObject.transform);
        instance.transform.localScale = new Vector3(1 * (counter * 0.05f),1 * (counter * 0.05f), 1 * (counter * 0.05f));
        instance.GetComponent<Rigidbody>().AddForce(gameObject.transform.right * 7, ForceMode.Impulse);
    }
}
