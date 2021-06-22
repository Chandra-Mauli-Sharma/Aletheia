using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterFlood : MonoBehaviour
{
    public float timeRemaining = 120;
    public bool timerIsRunning = false;
    public Text timeText;
    public CanvasRenderer m_Renderer;
    public GameObject water;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        m_Renderer = GetComponent<CanvasRenderer>();
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 100)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
                water.SetActive(true);
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
