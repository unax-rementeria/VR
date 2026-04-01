using UnityEngine;

public class TriggerSequenceManager : MonoBehaviour
{
    private bool triggerAActivated = false;
    private float timer;
    public float triggerInterval = 0.5f;
    private bool WrongOrder;

    score score;

    void Start()
    {
        timer = triggerInterval; 
    }

    void Update()
    {
        if (triggerAActivated)
        {
            timer -= Time.deltaTime; // Countdown
        }

        if (timer <= 0 && triggerAActivated)
        {
            triggerAActivated = false;
            WrongOrder = false;
            timer = triggerInterval;
        }

    }

    public void OnTriggerAEntered()
    {
        if (!WrongOrder)
        {
            triggerAActivated = true;
            score.AddScore();
        }
        Debug.Log("Trigger A activated — waiting for B...");
    }

    public void OnTriggerBEntered()
    {
        if (triggerAActivated)
        {
            Debug.Log("Correct order! A → B");
            triggerAActivated = false; // reset
            Destroy(gameObject);
            WrongOrder = false;

        }
        else
        {
            Debug.Log("Wrong order — A must come first.");
            WrongOrder = true;
        }
    }
}
