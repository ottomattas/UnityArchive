using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScore : MonoBehaviour
{
    // Define variable to capture Transform component
    // of a player and call it "player"
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        // Print player Z position to console
        Debug.Log(player.position.z);
    }
}
