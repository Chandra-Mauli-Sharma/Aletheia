using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishedLevel : MonoBehaviour
{
   void OnTriggerEnter(Collider others)
   {
       SceneManager.LoadScene(3);
   }
}
