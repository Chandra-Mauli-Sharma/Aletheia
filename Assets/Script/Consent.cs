using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
namespace UnityStandardAssets.Characters.FirstPerson
{
    public class Consent : MonoBehaviour
    {
    public GameObject con;
    public GameObject fps;
    private Damage dam;
        public void  Spawn()
        {
            dam.health=0.0f;
            dam.message="You don't have to enter the Lift";
        }
        public void Back()
        {
            con.SetActive(false);
            fps.GetComponent<FirstPersonController>().enabled=true;
            fps.GetComponent<CameraShake>().enabled=true;
            fps.transform.position-=Vector3.right*3;
        }
    }
}
