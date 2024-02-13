using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] private GameObject PauseMenuUI; //declares the pause menu as a game object

    [SerializeField] private bool isPaused; //boolean (true/false) for the pause menu. False by default.

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isPaused = true;  //When space is clicked, isPaused becomes true and the menu is active on screen.
        }

        if (isPaused)
        {
            ActivateMenu();
        }
        else
        {
            DeactivateMenu();
        }

    }

    void ActivateMenu()
    {
        PauseMenuUI.SetActive(true); //enables the pause menu game object
        Time.timeScale = 0; //turns off the game timer
        UnityEngine.Cursor.visible = true;  //enables cursor for use of pause menu
    }


    public void DeactivateMenu()
    {
        PauseMenuUI.SetActive(false); //disables the pause menu game object
        Time.timeScale = 1; //game time is resumed and the game continues as normal, same as "timer1.Enabled = false;"
        isPaused = false;
        UnityEngine.Cursor.visible = false; //disables cursor while playing game
    }

    public void QuitGameFromPaused()
    {
        Application.Quit();
        Debug.Log("quit from paused");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2); //loads the manin menu scene
    }

    public void BackToMainMenuMultiplayer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3); //loads the manin menu scene
    }
}
