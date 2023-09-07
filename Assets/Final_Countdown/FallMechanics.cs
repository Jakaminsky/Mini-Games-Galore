using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallMechanics : MonoBehaviour
{
    public Transform player;
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        if(player.position.y <= 1.45f)
        {
            rb.AddForce(-(player.transform.up * 10), ForceMode.Impulse);
        }
    }

}
