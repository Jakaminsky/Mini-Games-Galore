using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Destroy(gameObject);
    }
}
