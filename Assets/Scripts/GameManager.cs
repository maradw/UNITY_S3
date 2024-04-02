using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;
using UnityEngine.Events;


public class GameManager : MonoBehaviour
{
    public UnityEvent OnPlayerState;
    public GameObject _playerSquare;

    [HeaderAttribute(" Life variables")]
    public Image greenLifeBar;
    float currentLife = 10;
    float maxLife = 10;
    float minLife = 0;

    [HeaderAttribute(" Time variables")]
    public TextMeshProUGUI _textTimer;
    float timer = 0;

    [HeaderAttribute(" Score variables")]
    public TextMeshProUGUI _textPoints;
    int score = 0;
    void OnEnable()
    {
        PlayerControl.OnPlayerDamaged += CurrentLife;
        Hearts.OnHeartCollision += AddLife;
        Coins.OnCoinCollision += Score;
    }
    
    void LifeInGame()
    {

       greenLifeBar.fillAmount = currentLife / maxLife;
    }
    

    public void CurrentLife(float enemyLifeNumb)
    {
        currentLife = currentLife - enemyLifeNumb;
    }
    public void AddLife(float heartAdd)
    {
        currentLife = currentLife + heartAdd;

    }
    public void Score(int coin)
    {
        score = score + coin;
    }
    void Update()
    {
        LifeInGame();
        CurrentTime();
        
        _textPoints.text = " Score: " + score;
        
        State();
    }
    void CurrentTime()
    {
        timer += Time.deltaTime;
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        _textTimer.text = minutes + ":" + seconds;

    }

    public void State()
    {
        if (currentLife <= 0)
        {
            SceneManager.LoadScene("Lose");
        }
        else if (score >= 14)
        {
            SceneManager.LoadScene("Win");
        }
        
    }
    public void LoadHome()
    {
        SceneManager.LoadScene("Home");
    }

}
