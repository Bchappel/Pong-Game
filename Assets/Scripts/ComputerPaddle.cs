using UnityEngine;

public class ComputerPaddle : Paddle
{

    public Rigidbody2D ball; //declares the rigidbody ball
    public float speed = 30.0f; //speed of AI paddle

    private void FixedUpdate()
    {
        if (this.ball.velocity.x > 0.0f)
        {
            if (this.ball.position.y > this.transform.position.y) 
            {
                _rigidbody.AddForce(Vector2.up * this.speed);
            } 
            
            else if (this.ball.position.y < this.transform.position.y)  //makes the AI paddle follow the y value of the ball as it comes towards the paddle
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
        }
        else
        {
            if (this.transform.position.y > 0.0f) //if the ball is moving away from the paddle this part makes it hover in the middle of the screen
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
            
            else if (this.transform.position.y < 0.0f)
            {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }       
        }
    }
}