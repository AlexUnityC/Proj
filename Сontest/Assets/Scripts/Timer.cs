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
    void Update() //�� ���������� currentTime ���������� ��������� ����� � ��������� �� �����
    {
        currentTime -= Time.deltaTime;
        countdownText.text = currentTime.ToString("00");

        if (currentTime <= 0)  //����� ����� ����� �� ����������� ����� ����� ������
        {
            currentTime = 0;
            SceneManager.LoadScene(7);
        }
    }
}
