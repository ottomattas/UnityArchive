using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

            // Call Restart method
            Restart();
        }
    }

    // Create a custom Restart method
    void Restart
    {

    }
}
