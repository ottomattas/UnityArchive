using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    // Write custom function
    public void EndGame ()
    {
        gameHasEnded = true;
        Debug.Log("GAME OVER!");
    }
}
