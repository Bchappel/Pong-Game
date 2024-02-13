using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shutdown : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))  //if the escape key is pressed the game will be shutdown
        {
            Application.Quit();
            Debug.Log("application quit"); //prints "application quit" in the debug console
        }
    }
}
