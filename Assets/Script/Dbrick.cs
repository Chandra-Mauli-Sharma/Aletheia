using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dbrick : MonoBehaviour
{
    public GameObject dbricks;
    void OnTriggerEnter()
    {
            dbricks.GetComponent<Rigidbody>().useGravity=true;
            dbricks.SetActive(true);
    }
}
