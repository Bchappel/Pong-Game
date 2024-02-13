using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Paddle : Paddle
{
    private Vector2 _direction2; //Creates a 2D vairable (vector) that controls up/down functions of the paddle


    private void Update() //Equivalent of a timer however it is refreshed every frame that is rendered by unity instead of set interval.
    {
        if (Input.GetKey(KeyCode.UpArrow)) //Looks for key input (W or Up arrow), then tells the assigned vector2 that the paddle will move up.
        {
            _direction2 = Vector2.up;

        }
        else if (Input.GetKey(KeyCode.DownArrow)) //Looks for key input (S or Down arrow), then tells the assigned vector2 that the paddle will move down.
        {
            _direction2 = Vector2.down;
        }
        else
        {
            _direction2 = Vector2.zero; //if none of the keys are being used then the paddle will not move
        }
    }

    private void FixedUpdate() //Functions at a fixed time interval, like a traditional VB/Windows Form application
    {
        if (_direction2.sqrMagnitude != 0) //Only applies force when moving, hence the does not equal 0 (!=0)
        {
            _rigidbody2.AddForce(_direction2 * this.Paddle2Speed); //Adds force to paddle speed "PaddleSpeed" is a float declared on paddle script that is publicly accessed in this script
        }
    }
}
