using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairFall : MonoBehaviour
{

    public GameObject[] chairs;
    void Start()
    {
            chairs = GameObject.FindGameObjectsWithTag("chair");

        foreach (GameObject chair in chairs)
        {
            chair.transform.localPosition-=new Vector3(500.0f,0.0f,0.0f);
            Debug.Log("Ha");
        }
    }
}
