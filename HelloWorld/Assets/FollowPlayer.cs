using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    // Store the reference for the player
    public Transform player;
    // Create a Vector3 for camera offset
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // Transform the camera position to the position of our player
        // and add the specified offset
        transform.position = player.position + offset;
        // Display the position of our player
        //Debug.Log(player.position);
    }
}
