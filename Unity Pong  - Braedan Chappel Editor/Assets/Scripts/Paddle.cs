using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float PaddleSpeed = 10.0f; //Declares a float variable for paddle speed
    protected Rigidbody2D _rigidbody;

    public float Paddle2Speed = 10.0f;
    protected Rigidbody2D _rigidbody2;

    



    private void Awake() //Equivalent of form1 load, only happens once when project is started
    {
        _rigidbody = GetComponent<Rigidbody2D>();//Unity searches for the rigidbody component (Rigidbody2D)
        _rigidbody2 = GetComponent<Rigidbody2D>();
    }
    public void ResetPosition() //only called on game win
    {
        _rigidbody.position = new Vector2(_rigidbody.position.x, 0.0f);
        _rigidbody.velocity = Vector3.zero;


        _rigidbody2.position = new Vector2(_rigidbody2.position.x, 0.0f);
        _rigidbody2.velocity = Vector3.zero;
    }

}

