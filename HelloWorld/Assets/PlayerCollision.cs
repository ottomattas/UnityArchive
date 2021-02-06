using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Specify method for when object collides with something
    void OnCollisionEnter ()
    {
        // Print message to console
        Debug.Log("We hit something!");
    }
}
