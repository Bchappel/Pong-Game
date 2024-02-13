using UnityEngine;

public class BounceMultiplier : MonoBehaviour
{
    public float bounceVel; //variable that controls the velocity applied to the ball when it bounces off a surface


    private void OnCollisionEnter2D(Collision2D collision) //states when ball colides with anything the speed will increase by the add force factor.
    {
        Ball ball = collision.gameObject.GetComponent<Ball>(); //finds the component called "Ball"

        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceVel); //Bounce vel can be changed through the inspector on the walls and paddles, right now it is currently set to 10.

            
        }

    }
}
