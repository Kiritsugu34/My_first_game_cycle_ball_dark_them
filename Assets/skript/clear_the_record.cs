using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clear_the_record : MonoBehaviour
{
    public Text Cleared_record;
    public void clear_()
    {
        PlayerPrefs.DeleteKey(my_static_class.Record);
        Cleared_record.text="Record: "+PlayerPrefs.GetString(my_static_class.Record);
    }

}
