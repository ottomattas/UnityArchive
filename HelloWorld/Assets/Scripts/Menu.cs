using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Create public method for start
    public void StartGame ()
    {
        Debug.Log("START!");
        // Use SceneManager to load the next scene
        // based on currently active scene and the build index
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
