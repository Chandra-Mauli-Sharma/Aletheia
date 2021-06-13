using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dbrick : MonoBehaviour
{
    public GameObject dbricks;
    void OnTriggerEnter(Collider other)
    {
            dbricks.GetComponent<Rigidbody>().useGravity=true;
            dbricks.SetActive(true);
    }
}
