using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{

    // Create a public method to load sound upon completing level
    public void LoadSoundLevel ()
    {
        // Play a sound upon collision
            FindObjectOfType<AudioManager>().Play("PlayerWin");
    }

    // Create a public method to load next level
    public void LoadNextLevel ()
    {
        // Use SceneManager to load the next scene
        // based on currently active scene and the build index
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
