using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    public float health;
    public Slider slider;
    public GameObject gameObject;
    private bool flag=false;
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
            SceneManager.LoadScene(2);
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.collider.tag == "door"||hit.collider.tag == "wall")
        {
            health=health-0.50f;
        }
        else if(hit.collider.tag=="brick"&&flag!=true)
        {
            health=health-50.0f;
        }
    }
}