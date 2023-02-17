using System;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text ScoreText;
    public TMP_Text timerText;
    private static int _score;
    private float _timer;
    //private GameObject[] _collideableArray;

    private void Start()
    {
        _timer = 99.0f;
        _score = 0;
        //_collideableArray = GameObject.FindGameObjectsWithTag("Collidable");
    }

    private void Update()
    {
        _timer -= Time.deltaTime;
        UpdateTimer();
    }
    
    public void UpdateScore(int targetValue)
    {
        _score += targetValue;
        ScoreText.text = "Score: " + _score;
    }

    private void UpdateTimer()
    {
        int timerString = (int)Math.Round(_timer);
        timerText.text = timerString.ToString();
    }
}
