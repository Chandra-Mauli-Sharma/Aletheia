using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class OptionMenu : MonoBehaviour
{

    public GameObject option;
    public static bool state=false;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("k"))
        {
           if(!state)
           {
               Option();
           }
           else
           {
               Back();
           }
        }
    

    }
    public void Option()
    {
        option.SetActive(true);
        state=true;
        Time.timeScale=0f;
    }
    public void Back()
    {
        option.SetActive(false);
        state=false;
        Time.timeScale=1f;
    }
}
