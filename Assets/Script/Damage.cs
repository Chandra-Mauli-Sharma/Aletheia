using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    public GameObject gameObject;
    public float health;
    public Slider slider;
    private bool flag=false;
    public string message;
    public Text mtext;
    void Start()
    {
        health=100.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(health>0)
        {
            slider.value=health;
        }
        else
        {
            gameObject.SetActive(true);
            mtext.text=message;
            if(Input.anyKey)
            {
                SceneManager.LoadScene(2);
            }
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(health>0)
        {
            if(hit.collider.tag == "door"||hit.collider.tag == "wall")
            {
                message="Died because of hitting on wall";
                health=health-0.50f;
            }
            else if(hit.collider.tag == "building")
            {
                message="Died because of staying in building";
                health=health-0.02f;
            }
            else if(hit.collider.tag=="brick" || hit.collider.tag=="brick1")
            {
                message="Died because of falling debris";
                if(hit.collider.GetComponent<Rigidbody>().velocity.y>0.0f  && (!flag))         
                {
                    health=health-50.0f;
                    flag=true;
                }
                else
                {
                    health=health-0.05f;                
                }
            }
        }
    }
    
}
