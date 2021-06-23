using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRise : MonoBehaviour
{
    public GameObject gameObject;
    void Update()
    {
        if(gameObject.transform.localScale.y<=25.0f)
            {
                gameObject.transform.localScale+=new Vector3(0.0f,0.05f,0.0f);
            }
    }
}
