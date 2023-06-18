using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float currentTime;
    public float startingTime = 60f;

    private Text countdownText;
    void Start()
    {
        countdownText = GetComponent<Text>();
        currentTime = startingTime;
    }
    void Update() //от переменной currentTime отнимается прошедшее время и выводится на экран
    {
        currentTime -= Time.deltaTime;
        countdownText.text = currentTime.ToString("00");

        if (currentTime <= 0)  //когда время вышло то загружается сцена конца уровня
        {
            currentTime = 0;
            SceneManager.LoadScene(7);
        }
    }
}
