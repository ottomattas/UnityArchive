using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    // Define variable to capture Transform component
    // of a player and call it "player"
    public Transform player;
    
    // Define variable to capture UI Text component
    // and call it "scoreText"
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        //
        scoreText.text = player.position.z.ToString("0");
        // Print player Z position to console
        // Debug.Log(player.position.z);
    }
}
