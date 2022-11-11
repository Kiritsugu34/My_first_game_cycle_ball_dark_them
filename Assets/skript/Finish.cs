using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Globalization;

public class Finish : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(0);
    }

    private string _time;
    public Text _time_text;
    public Text Record_text;
    float time_num=1;
    float Record_num;
    void Start()
    {
        NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
        {
            NumberDecimalSeparator = ".",
        };

        //Час за текущий раунд
        _time = PlayerPrefs.GetString("Time");
        _time_text.text = "Time: "+ _time;
        //запис рекорду
        time_num = Convert.ToSingle(_time, numberFormatInfo);
       Record_num=PlayerPrefs.GetFloat(my_static_class.Record);
        if (time_num>Record_num)
        {
            Record_num = time_num;
            PlayerPrefs.SetFloat(my_static_class.Record, Record_num);
            Record_num = PlayerPrefs.GetFloat(my_static_class.Record);
        }
        
        Record_text.text="Record: " + Record_num.ToString();
    }
}
