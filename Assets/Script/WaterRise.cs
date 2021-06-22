using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRise : MonoBehaviour
{
    public GameObject gameObject;
    void Update()
    {
        gameObject.transform.localScale+=new Vector3(0.0f,0.00005f,0.0f);
    }
}
