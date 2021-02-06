using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravityForceExample : MonoBehaviour
{
    // Reference to the Rigidbody component
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        // Print out a debug message to the console
        Debug.Log("Hello, World!");
        // Turn off gravity
        rb.useGravity = false;
        // Add initial force
        rb.AddForce(0, -500, 500);
    }

    // Update is called once per frame,
    // We use FixedUpdate to mess with physics
    void FixedUpdate()
    {
        // Add force for every new frame
        rb.AddForce(0, 0, 100 * Time.deltaTime);
    }
}
