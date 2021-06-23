using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        controller.height = 1.5f;
    }
    void Update()
    {
        if(Input.GetKeyDown("c"))
        {
            controller.height = 0.2f;
        }
        if(Input.GetKeyUp("c"))
        {
            controller.height = 1.5f;
        }
    }
}
