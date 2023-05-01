using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;

    public AudioSource select;

    public void StartGame()
    {
        select.Play();
        SceneManager.LoadScene(sceneToLoad);
        Debug.Log("New Scene Loaded!");
    }

    public void QuitGame()
    {
        select.Play();
        Application.Quit();
        Debug.Log("Quit Game!");
    }
}
