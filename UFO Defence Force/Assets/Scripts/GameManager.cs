using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    private GameObject gameOverText;

    private GameObject restartButton;

    public int sceneToLoad;

    public AudioSource WompWomp;


    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }

    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
        restartButton = GameObject.Find("RestartButton");
    }

    void Update()
    {
        if(isGameOver)
        {
            WompWomp.Play();
            EndGame();
        }
        else
            gameOverText.gameObject.SetActive(false);
  
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(sceneToLoad);
        Debug.Log("New Scene Loaded!");
    }

    public void EndGame()
    {
        
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0;
        
    }
}
