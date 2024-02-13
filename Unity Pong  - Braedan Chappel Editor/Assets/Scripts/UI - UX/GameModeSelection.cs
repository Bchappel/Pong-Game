using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameModeSelection : MonoBehaviour
{
    public void SinglePlayer ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //load scene 1 (singleplayer)
    }

    public void MultiPlayer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2); //load scene 2 (multiplayer)
    }


    public void ChaosMode ()
    {
        Debug.Log("Chaos Mode Active");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("Back");
    }


    public void QuitGame()
    {

        Debug.Log("Quit");
        Application.Quit();
    }

}
