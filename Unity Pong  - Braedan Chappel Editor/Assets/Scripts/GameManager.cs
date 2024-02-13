using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public int rScore; //right score interger
    public int lScore; //left score interger

    public Text rightScoreText; //displays the text for right score
    public Text leftScoreText;  //displays the text for left score

    private GameObject rPaddle;
    private GameObject lPaddle;

    public Paddle rightPaddle;
    public Paddle leftPaddle;

    public void Start()
    {
        Cursor.visible = false;

        lPaddle = GameObject.Find("leftPaddlePlayer");
        


    }

    public void RightScores()
    {
        rScore++;   //Adds 1 to the right score
        
        this.rightScoreText.text = rScore.ToString(); //displays score as a string to be used on the on screen display

        

        CheckWinSingle(); //checks if the score has reached 10 for the win condition

        DebuffEnabled();

        ResetRound(); //resets the round after score
    }

    public void LeftScores()
    {
        lScore++; //Adds 1 to the right score

        this.leftScoreText.text = lScore.ToString(); //displays score as a string to be used on the on screen display

        CheckWinSingle();//checks if the score has reached 10 for the win condition

        DebuffEnabled();

        ResetRound(); //resets the round after score
    }
   
    public void MultiplayerRightScores()
    {
        rScore++; //Adds 1 to the right score in the multiplayer enviorment

        this.rightScoreText.text = rScore.ToString();
        CheckWinMultiplayer();

        ResetRound();
    }

    public void MultiplayerLeftScores()
    {
        lScore++; //Adds 1 to the right score in the multiplayer enviorment

        this.leftScoreText.text = lScore.ToString();
        CheckWinMultiplayer();

        ResetRound();
    }


    public void CheckWinSingle()
    {
         if (rScore == 10) 
         {
             Debug.Log("Left Win");
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +4); //loads the scene corresponding with the win screen for the right player
            
        }

         if (lScore == 10)
         {
             Debug.Log("Right Win");
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3); //loads the scene corresponding with the win screen for the left player
             
        }
    }

    public void CheckWinMultiplayer()
    {
        if (rScore == 10)
        {
            Debug.Log("Right Win");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            
        }



        if (lScore == 10)
        {
            Debug.Log("Right Win");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
            
        }
    }

    public void DebuffEnabled()
    {
        if (lScore == 5)
        {
            Debug.Log("left debuff enabled");
            lPaddle.gameObject.transform.localScale += new Vector3(0f, 1.2f, 0f); //increases the size of the paddle for the blue team against AI only.
        }


    }




private void ResetRound()
    {
        this.ball.CenterBall();  //centers the ball to the middle of the screen (same principle as doing it in visual studio)
        this.rightPaddle.ResetPosition(); //moves the right paddle to the center of the screen
        this.leftPaddle.ResetPosition(); //moves the left paddle to the center of the screen
        this.ball.AddStartingForce(); //adds an initial speed value to the ball off the start, without this the ball wouldnt move
    }

}
