using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction; //Creates a 2D vairable (vector) that controls up/down functions of the paddle


    private void Update() //Equivalent of a timer however it is refreshed every frame that is rendered by unity instead of set interval.
    {
        if (Input.GetKey(KeyCode.W)) //Looks for key input (W), then tells the assigned vector2 that the paddle will move up on the y-axis.
        { 
        _direction = Vector2.up;

        } 
        else  if (Input.GetKey(KeyCode.S)) //Looks for key input (S), then tells the assigned vector2 that the paddle will move down on the y-axis.
        { 
            _direction = Vector2.down;
        } 
        else 
        {
            _direction = Vector2.zero; //if none of the keys are being used then the paddle will not move
        }
    }

    private void FixedUpdate() //Functions at a fixed time interval, like a traditional VB/Windows Form application timer.
    {
        if(_direction.sqrMagnitude != 0) //Only applies force when moving, hence the does not equal 0 (!=0)
        {
            _rigidbody.AddForce(_direction * this.PaddleSpeed); //Adds force to paddle speed "PaddleSpeed" is a float declared on paddle script that is publicly accessed in this script
        }
    }

}
