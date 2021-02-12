using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    // Stop player movement on collision
    public PlayerMovement movement;

    // Specify method for when object collides with something
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            // Stop movement
            movement.enabled = false;
            Debug.Log("We hit an obstacle!");

            // Play a sound upon collision
            FindObjectOfType<AudioManager>().Play("PlayerBump");

            // Find GameManager object and call EndGame method
            FindObjectOfType<GameManager>().EndGame();
        }
        // Print message to console
        //Debug.Log(collisionInfo.collider.name);
    }
}
