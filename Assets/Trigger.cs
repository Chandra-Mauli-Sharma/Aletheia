using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Trigger : MonoBehaviour
{
    public GameObject liftInfo; 
   void OnTriggerEnter(Collider others)
   {
       liftInfo.SetActive(true);
   }
}
