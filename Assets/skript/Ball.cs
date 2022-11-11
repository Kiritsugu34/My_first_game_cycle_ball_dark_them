
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//
//public static string time_cycle="time_cycle";
public class Ball : MonoBehaviour
{
    public Text Record_time;
    private string Record_time_str;
 

    private void OnTriggerEnter2D(Collider2D other)
    {   
        Scene scene = SceneManager.GetActiveScene();
        if (scene.buildIndex==1)                 
           my_static_class.Record = "Record_cycle";
        else if(scene.buildIndex==2)
            my_static_class.Record = "Record_8";       
        else
        {
            Debug.Log("EROR_scen_time_number_");
        }
        if (other.gameObject.tag=="Enemy")
        {
            Record_time_str = Record_time.text;
            PlayerPrefs.SetString("Time", Record_time_str);
            SceneManager.LoadScene(3);
        }
    }
}
