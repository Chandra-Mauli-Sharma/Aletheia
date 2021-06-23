using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderTable : MonoBehaviour
{
    public GameObject gameObject;
    public float timerem;
    public bool flag;
    void Start()
    {
        flag=false;
    }
    void Update()
    {
        if(flag)
        {
            timerem-=Time.deltaTime;
            Debug.Log(timerem);
        }
    }
    void OnTriggerEnter(Collider others)
   {
       flag=true;
        if(timerem<0)
        {
            gameObject.GetComponent<CameraShake>().enabled=false;
        }
   }
}
