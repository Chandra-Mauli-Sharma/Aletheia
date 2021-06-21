using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
namespace UnityStandardAssets.Characters.FirstPerson
{
   public class Trigger : MonoBehaviour
   {
      public GameObject liftInfo; 
      public GameObject gameObject; 
      bool flag=true;
      void OnTriggerEnter(Collider others)
      {
         if(flag==true)
         {
               liftInfo.SetActive(true);
               gameObject.GetComponent<FirstPersonController>().enabled=false;
               gameObject.GetComponent<CameraShake>().enabled=false;
            flag=false;
         }
      }
   }
}