using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Purchase : MonoBehaviour
{
    public Text mtext;
    public GameObject gameObject;
     void OnTriggerEnter(Collider others)
   {
       
            gameObject.SetActive(true);
            mtext.text="Supplies Collected";
            if(Input.anyKey)
            {
                SceneManager.LoadScene(9);
            }
   }
}
