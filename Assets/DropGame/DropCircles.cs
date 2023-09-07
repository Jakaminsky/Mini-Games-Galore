using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropCircles : MonoBehaviour
{
    public Transform box;
    public GameObject prefab;
    public float dropTime = 1.0f;

    public int counter = 0;

    public static float timeRemaining = 3.1f;
    public int time = Mathf.FloorToInt(timeRemaining);
    public bool timerIsRunning = false;

    public Text timer;

    private void Start()
    {
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                time = Mathf.FloorToInt(timeRemaining);
                timer.text = time.ToString();
            }
            else
            {
                timer.enabled = false;
                StartCoroutine(WaitAndDrop(dropTime));
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }

    private void Faster()
    {
        if (counter == 10 || counter == 30 || counter == 70)
        {
            StopCoroutine(WaitAndDrop(dropTime));
            dropTime = dropTime - 0.3f;
            StartCoroutine(WaitAndDrop(dropTime));
        }
        else if(counter==150)
        {
            StopCoroutine(WaitAndDrop(dropTime));
            dropTime = 0.01f;
            StartCoroutine(WaitAndDrop(dropTime));
        }
    }

    private IEnumerator WaitAndDrop(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            InstatiateObject();
            counter++;
            Faster();
        }
    }

    void InstatiateObject()
    {
        float randomX = Random.Range(-10, 10);
        float randomZ = Random.Range(-10, 10);

        Instantiate(prefab, new Vector3(randomX, 10.0f, randomZ), Quaternion.identity);
    }
}
