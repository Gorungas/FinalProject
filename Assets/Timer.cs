using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{

    public float totalTime;
    public static float minutes;
    public static float seconds;
    public GameObject controller;
    
    public TextMeshProUGUI Countdown;

    // Start is called before the first frame update
    void Start()
    {
        minutes = (totalTime / 60f);
        seconds = (totalTime % 60f);
    }

    // Update is called once per frame
    void Update()
    {
        
        Countdown.text = (("TIME REMAINING: ") + Mathf.RoundToInt(minutes) + (":") + Mathf.RoundToInt(seconds));
        updateTime();


    }

    public void  updateTime()
    {
        if (Mathf.RoundToInt(totalTime) >= -39)
        {
            if (seconds <= 0.0f)
            {
                minutes -= 1f;
                seconds += 60f;
            }
            if (seconds < 10.0f)
                Countdown.text = (("TIME REMAINING: ") + Mathf.RoundToInt(minutes) + (":0") + Mathf.RoundToInt(seconds));
            totalTime -= Time.deltaTime;

            seconds -= (Time.deltaTime / 2);
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("GameOver");
        }
      
    }
}
