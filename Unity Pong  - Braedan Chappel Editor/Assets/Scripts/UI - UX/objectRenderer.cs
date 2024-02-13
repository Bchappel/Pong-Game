using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectRenderer : MonoBehaviour
{

    //I didnt write this code I found this on https://www.youtube.com/watch?v=DdAfwHYNFOE&ab_channel=ZeroKelvinTutorials however, I optimzed it to fit into the context of  my game as the center circle.

    public LineRenderer circleRenderer;
    // Start is called before the first frame update
    void Start()
    {
        DrawCircle(180, 1);
    }

    void DrawCircle(int steps, float radius)
    {
        circleRenderer.positionCount = steps;

        for (int currentStep = 0; currentStep < steps; currentStep++)
        {
            float circumfrenceProgress = (float)currentStep / steps;

            float currentRadian = circumfrenceProgress * 2 * Mathf.PI;

            float xScaled = Mathf.Cos(currentRadian);
            float yScaled = Mathf.Sin(currentRadian);

            float x = xScaled * radius*1.5f;  //Controls size on x-axis
            float y = yScaled * radius * 1.5f; //controls size on y-axis (in this case it is getting multiplied by 1.5 to make it larger.

            Vector2 currentPosition = new Vector2(x, y);

            circleRenderer.SetPosition(currentStep, currentPosition);
        }
    }

}
