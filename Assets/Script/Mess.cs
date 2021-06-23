using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mess : MonoBehaviour
{
    public Text mtext;
    public GameObject gameObject;
     void OnTriggerEnter(Collider others)
   {
       
       gameObject.SetActive(true);
           mtext.text="You don't have to stay under building";
            if(Input.anyKey)
            {
                SceneManager.LoadScene(7);
            }
   }

   
}
