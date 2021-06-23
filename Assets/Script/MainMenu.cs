using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject gameObject;
    public Slider slider;
    public GameObject bgm;
    public void PlayGame ()
    {
        StartCoroutine(LoadAsynchronously ());
    }
    public void PlayGame2 ()
    {
        StartCoroutine(LoadAsynchronously2 ());
    }
    public void FloodS ()
    {
        StartCoroutine(LoadAsynchronously3 ());
    }
     IEnumerator LoadAsynchronously3 ()
    {
        gameObject.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(8);

        while(!operation.isDone)
        {
            float pro=Mathf.Clamp01(operation.progress/.9f);
            slider.value=pro;
            yield return null;
        }
        if(operation.isDone)
        {
            bgm.SetActive(false);
        }
    }
    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
    IEnumerator LoadAsynchronously2 ()
    {
        gameObject.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(6);

        while(!operation.isDone)
        {
            float pro=Mathf.Clamp01(operation.progress/.9f);
            slider.value=pro;
            yield return null;
        }
        if(operation.isDone)
        {
            bgm.SetActive(false);
        }
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
        if(operation.isDone)
        {
            bgm.SetActive(false);
        }
    }
}
