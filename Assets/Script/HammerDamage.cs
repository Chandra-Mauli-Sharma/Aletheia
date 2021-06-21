using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HammerDamage : MonoBehaviour
{
    public GameObject gameObject;
    public float health;
    public Slider slider;
    private bool flag;
    void Start()
    {
        health=100.0f;
        flag=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(health>0)
        {
            slider.value=health;  
        }
        else
        {
           Destroy(gameObject);
        }
    }
    void OnCollisionStay(Collision collision)
    {
        if ((collision.collider.name == "hammer")&& flag)
        {
            flag=false;
            health=health-30.0f;
            StartCoroutine(Stay());
        }
    }
    IEnumerator Stay()
    {
        yield return new WaitForSeconds(5);
        flag=true;
    }
}
