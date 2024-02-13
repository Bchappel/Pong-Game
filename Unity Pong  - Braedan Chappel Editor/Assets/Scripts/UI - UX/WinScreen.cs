using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public void RedWinBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);  //Loads the the scene corresponding to the event that red player wins
    }

    public void BlueWinsBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);   //Loads the the scene corresponding to the event that blue player wins
    }


}
