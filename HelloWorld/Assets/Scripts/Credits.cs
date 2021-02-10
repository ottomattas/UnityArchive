using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    // Create public method for quit
    public void Quit ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
