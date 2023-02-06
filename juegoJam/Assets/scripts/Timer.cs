using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Timer : MonoBehaviour
{
    public static Timer instance;
    public float timeRemaining = 60;
    public bool timerIsRunning = false;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        UIManager.instance.timer.text = timeRemaining.ToString("0");
        timerIsRunning = true;
    }
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                UIManager.instance.timer.text = timeRemaining.ToString("0");
            }
            else
            {
                timeRemaining = 0;
                UIManager.instance.timer.text = timeRemaining.ToString("0");
                timerIsRunning = false;
                GameManager.instance.GameWin();
            }
        }
    }
}