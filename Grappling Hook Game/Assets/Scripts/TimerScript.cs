using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public TextMeshProUGUI timertext;

    bool isRunning = false;

    private string minutes;

    private string seconds;

    public float amountofTime = 5000;

    void Start()
    {
       

      
    
    }

    // Update is called once per frame

    void Timer()
    {
        if(amountofTime > 0)
        {
            amountofTime -= Time.deltaTime;
        }
        else
        {
            amountofTime = 0;
        }
    }

    void SetTimerText()
    {
        int min = Mathf.FloorToInt(amountofTime / 60);

        int sec = Mathf.FloorToInt(amountofTime) - (min * 60);

        string secStr = " ";
        
        if(sec < 10)
        {
            secStr += "0";
        }
        secStr += sec;
        timertext.text = min + ":" + secStr;
 
    }
    void Update()
    {
        if (!isRunning)
        {
            Timer();
            SetTimerText();
        }

    }


    /*
    public static bool Timer(bool isrunning)
    {
        
        float t = 500;

        isrunning = false;

        while(!isrunning)
        {
            isrunning = true;

            float minutes = Mathf.FloorToInt(t / 60);

            float seconds = Mathf.FloorToInt(t % 60);

           
           
            if (t > 0)
            {
                t -= Time.deltaTime;
            }
            else
            {
                t = 0;
            }
        }
        return false;
    }
    */
  
}
