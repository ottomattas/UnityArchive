using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Reference to the Rigidbody component
    public Rigidbody rb;

    // Create a variable for forward force
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame,
    // We use FixedUpdate to mess with physics
    void FixedUpdate()
    {
        // Add forward force for every new frame
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
    
        if ( Input.GetKey("d") )
        {
            // Add right force for every new frame
            // when "d" key is pressed
            rb.AddForce( sidewaysForce * Time.deltaTime, 0, 0 );
        }

        if ( Input.GetKey("a") )
        {
            // Add right force for every new frame
            // when "a" key is pressed
            rb.AddForce( -sidewaysForce * Time.deltaTime, 0, 0 );
        }
    }
}
