using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    // Store the reference for the player
    public Transform player;
    // Va
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // Transform the camera position to the position of our player
        transform.position = player.position;
        // Display the position of our player
        //Debug.Log(player.position);
    }
}
