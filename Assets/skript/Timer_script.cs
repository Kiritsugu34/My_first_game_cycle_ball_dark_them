
using System;
using UnityEngine;
using UnityEngine.UI;


public class Timer_script : MonoBehaviour
{
    public Text TIMER_TEXT;
    float timer_second_1=0;
    float timer_second_2 = 0;
    float timer_minute_1 = 0;
    float timer_minute_2 = 0;
    void Update()
    {
        timer_second_1 += Time.deltaTime;
      
        if (timer_second_1 > 9)
        {
            timer_second_2++;
            if (timer_second_2 > 5) 
            {
                timer_minute_1++;
                if (timer_minute_1 > 9) 
                {
                    timer_minute_2++;
                    timer_minute_1 = 0;
                }
                timer_second_2 = 0;
            };

            timer_second_1 = 0;
        };
          
        TIMER_TEXT.text = timer_minute_2.ToString()+timer_minute_1.ToString()+'.'
            +timer_second_2.ToString()+ Mathf.Round(timer_second_1).ToString();
    }

}
