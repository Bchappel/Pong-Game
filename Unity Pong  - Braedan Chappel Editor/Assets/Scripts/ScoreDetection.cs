using UnityEngine;
using UnityEngine.EventSystems;

public class ScoreDetection : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger; //Declaring the event that triggers a score
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current); //When ball colides with scoring zone an event is triggered
            this.scoreTrigger.Invoke(eventData);
        }

    }
}
