using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    // Store the reference for the player
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        // Display the position of our player
        Debug.Log(player.position);
    }
}
