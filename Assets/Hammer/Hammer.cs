using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    public GameObject gameObject;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.transform.Rotate(0.0f,30.0f,0.0f, Space.Self);
        }
        if (Input.GetMouseButtonUp(0))
        {
            gameObject.transform.Rotate(0.0f,-30.0f,0.0f, Space.Self);
        }
    }
}
