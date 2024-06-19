using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        // Note: This will only output in a built game, 
        // as Unity does not quit when testing in the editor
    }
}