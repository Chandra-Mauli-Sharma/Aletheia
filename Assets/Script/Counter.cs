using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public float timeRemaining = 120;
    public bool timerIsRunning = false;
    public Text timeText;
    public CanvasRenderer m_Renderer;

    [SerializeField]
    private Damage dam;

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
            if (timeRemaining > 30)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else if(timeRemaining>0 && timeRemaining<=30)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
                m_Renderer.SetColor(Color.red);
                
            }
            else
            {
                dam.health=0.0f;
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
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
