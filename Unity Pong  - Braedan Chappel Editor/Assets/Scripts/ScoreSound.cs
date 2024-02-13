using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSound : MonoBehaviour
{
    public AudioSource ScoreSoundEffect; //declares a sound effect to be played

    void Start()
    {
        ScoreSoundEffect = GetComponent<AudioSource>(); //gets the audio player commponent from the inspector on the left/right wall
    }

    public void OnCollisionEnter2D(Collision2D sCol)
    {
        if (sCol.gameObject.name == "rBall") //if the object rBall collides with the left or right wall 
        {
            ScoreSoundEffect.Play(); //plays the score sound effect
        }
    }

}
