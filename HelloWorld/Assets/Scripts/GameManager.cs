using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Create a boolean variable to check for game end
    bool gameHasEnded = false;

    // Create a public variable for delaying restart, default 1 sec

    public float restartDelay = 1f;
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

            // Call Restart method with invoke to have a delay
            Invoke("Restart", restartDelay);
        }
    }

    // Create a custom Restart method
    void Restart ()
    {
        // Load currently active scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
