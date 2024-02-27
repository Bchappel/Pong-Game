using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Ballspeed = 200.0f; //Speed of the ball variable

    private Rigidbody2D _rigidbody; //declares a Rigidbody2D

    public AudioSource PongSoundEffect;  //declares a public audio source

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>(); //calls for the rigidbody component built into unity engine
    }


    private void Start() 
    {
        CenterBall(); //When the program starts ensures that the ball is centered
        AddStartingForce(); //Starts velocity

        PongSoundEffect = GetComponent<AudioSource>(); //gets the audiosource component in the hierarchy
    }

    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f); //"y" value determines the angle or pitch of the ball on the start on a random range between 0.5 and 1.0 up or down.

        Vector2 direction = new Vector2(x, y); //takes the random float values (x,y) selected and assignes a 2d vector to it called direction
        _rigidbody.AddForce(direction*this.Ballspeed); //Adds the speed and direction to the ball to the rigidbody
    }
    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force); //Adds force to the rigidbody then to the ball
    }

    public void CenterBall()
    {
        _rigidbody.position = Vector2.zero; //Centers the ball to the center of the arena
        _rigidbody.velocity = Vector3.zero; //Reset Velocity back to the base float #


    }


    public void OnCollisionEnter2D(Collision2D col) //controls the sound effects
    {
        if (col.gameObject.name == "TopWall") //states that when ball collides with object "TopWall" play desired audio effect, logic is true for each instance.
        {
            Debug.Log(" top collision");

            PongSoundEffect.Play();

        }


        if (col.gameObject.name == "PlayerPaddle")
        {
            Debug.Log(" right collision");
            PongSoundEffect.Play();
        }

        if (col.gameObject.name == "leftPaddlePlayer")
        {
            Debug.Log(" right paddle collision");
            PongSoundEffect.Play();
        }

        if (col.gameObject.name == "Player2Paddle")
        {
            Debug.Log("left collision");
            PongSoundEffect.Play();
        }

        if (col.gameObject.name == "ComputerPaddle")
        {
            Debug.Log("left collision");
            PongSoundEffect.Play();
        }

        if (col.gameObject.name == "BottomWall")
        {
            Debug.Log("bottom collision");
            PongSoundEffect.Play();
        }
    }

}
