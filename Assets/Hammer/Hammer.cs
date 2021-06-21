using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    public GameObject gameObject;
    private bool enableAnim;
    // Start is called before the first frame update
    void Start()
    {
        enableAnim=false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("h"))
        {
            gameObject.SetActive(!(gameObject.activeSelf));
        }
        if (Input.GetKeyDown("j"))
        {
            gameObject.GetComponent<Animator>().enabled=!(enableAnim);
            enableAnim=!enableAnim;
        }
    }
}
