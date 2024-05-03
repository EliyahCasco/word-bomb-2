using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void exitGame()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("Game Closed");
    }

    public void startGame()
    {
        SceneManager.LoadScene("Main Game"); 
    }

}
