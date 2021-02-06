using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Specify method for when object collides with something
    void OnCollisionEnter (Collision collisionInfo)
    {
        // Print message to console
        Debug.Log(collisionInfo.collider.name);
    }
}
