using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    // Interpolate light color between two colors back and forth
    float duration = 0.5f;
    Color color0 = Color.red;
    Color color1=new Color(0.3962264f, 0.3909932f, 0.3909932f, 1f);
    Light lt;

    void Start()
    {
        lt = GetComponent<Light>();
    }

    void Update()
    {
        // set light color
        float t = Mathf.PingPong(Time.time, duration) / duration;
        lt.color = Color.Lerp(color0, color1, t);
    }
}
