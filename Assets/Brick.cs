using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public GameObject[] bricks;
    void Start()
    {
        bricks = GameObject.FindGameObjectsWithTag("brick");
    }
    void OnTriggerEnter(Collider other)
    {
        foreach (GameObject brick in bricks)
        {
            brick.GetComponent<Rigidbody>().useGravity=true;
        }
    }
}
