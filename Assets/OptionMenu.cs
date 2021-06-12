using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
using UnityEngine.UI;

namespace UnityStandardAssets.Characters.FirstPerson
{
public class OptionMenu : MonoBehaviour
{

    public GameObject option;
    public GameObject fps;
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
        fps.GetComponent<FirstPersonController>().enabled=false;
        fps.GetComponent<CameraShake>().enabled=false;
    }
    public void Back()
    {
        option.SetActive(false);
        state=false;
        Time.timeScale=1f;
fps.GetComponent<FirstPersonController>().enabled=true;
        fps.GetComponent<CameraShake>().enabled=true;
    }
}
}