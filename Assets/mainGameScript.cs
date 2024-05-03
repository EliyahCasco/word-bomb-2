using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainGameScript : MonoBehaviour
{

    private void Start()
    {
        Application.runInBackground = true;
    }


    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void goToMain()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void quitGame()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("quit");
    }
}
