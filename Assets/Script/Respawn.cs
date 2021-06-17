using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Respawn : MonoBehaviour
{
    public GameObject gameObject;
    public Slider slider;
    public void Spawn()
    {
        StartCoroutine(LoadAsynchronously ());
    }
    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
    IEnumerator LoadAsynchronously ()
    {
        gameObject.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(1);

        while(!operation.isDone)
        {
            float pro=Mathf.Clamp01(operation.progress/.9f);
            slider.value=pro;
            yield return null;
        }
    }
}
