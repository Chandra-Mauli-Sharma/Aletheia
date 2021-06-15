using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    private GameObject[] bricks;
    public string s;
    void Start()
    {
        bricks = GameObject.FindGameObjectsWithTag(s);
    }
    void OnTriggerEnter(Collider other)
    {
        foreach (GameObject brick in bricks)
        {
            brick.GetComponent<Rigidbody>().useGravity=true;
        }
    }
}
