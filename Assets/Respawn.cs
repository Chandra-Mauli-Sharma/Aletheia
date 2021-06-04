using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public void Spawn()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
