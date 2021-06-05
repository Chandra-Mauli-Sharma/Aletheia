using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    public float health;
    public Slider slider;
    public GameObject gameObject;
    void Start()
    {
        health=100.0f;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value=health;
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.collider.tag == "door"||hit.collider.tag == "wall")
        {
            health=health-0.50f;
        }
    }
}
