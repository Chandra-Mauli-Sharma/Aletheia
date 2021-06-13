using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick1 : MonoBehaviour
{
     private GameObject[] bricks1;
    void Start()
    {
        bricks1 = GameObject.FindGameObjectsWithTag("brick1");
    }
    void OnTriggerEnter(Collider other)
    {
        foreach (GameObject brick1 in bricks1)
        {
            brick1.GetComponent<Rigidbody>().useGravity=true;
        }
    }
}
