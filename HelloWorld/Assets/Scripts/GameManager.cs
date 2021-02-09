using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    // Write custom EndGame method
    public void EndGame ()
    {
        // Check if game has already ended
        if (gameHasEnded == false)
        {
            // End game
            gameHasEnded = true;

            // Print to console
            Debug.Log("GAME OVER!");
        }
    }
}
