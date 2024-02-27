using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtons : MonoBehaviour
{
    public void BackToMainMenuRedWin() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -5);
        Debug.Log("Back");
    }

    public void BackToMainMenuBlueWin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
        Debug.Log("Back");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

    public void QuitGame()
    {

        Debug.Log("Quit");
        Application.Quit();
    }

}
