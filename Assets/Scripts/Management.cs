using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Management : MonoBehaviour
{
    public Button Pausebotton;
    public GameObject PauseBar;
    public bool pause;
    public void Start()
    {
        PauseBar.SetActive(false);
    }
    
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void LoadHome()
    {
        SceneManager.LoadScene("Home");
    }
    public void Pause()
    {
        pause = !pause;
        PauseBar.SetActive(pause);
        if (pause)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
