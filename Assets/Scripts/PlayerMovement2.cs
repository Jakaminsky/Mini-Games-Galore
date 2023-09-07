// This script moves a game object left, right, forwards, backwards...
// using input from keyboard/gamepad (set in the Input Manager)
// 'Update' Method is used for the Input (keyboard/Gamepad)
// 'Fixed' Method is used for physics movement
// The Input is 'Normalized' to prevent faster diagonal movement
// 'Time.fixedDeltaTime' is used to keep the physics framrate consistant on all devices
// In Update we get the Input for left, right, up and down and put it in the variable 'movement'...
// We only get the input of x and z, y is left at 0 as it's not required
// 'Normalized' diagonals to prevent faster movement when two inputs are used together
// We multiply the 'speed' variable to the Rigidbody's velocity...
// and also multiply 'Time.fixedDeltaTime' to keep the movement consistant on all devices

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public float speed = 100f;
    public Rigidbody rb;
    public Vector3 movement;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal2"), 0, Input.GetAxis("Vertical2")).normalized;
    }

    void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector3 direction)
    {
        rb.velocity = direction * speed * Time.fixedDeltaTime;
    }
}
