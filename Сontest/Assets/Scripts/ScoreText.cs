using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private Text ScoreCheck;
    void Start()
    {
        ScoreCheck = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update() //����� ���������� ����� ��������� �� ���� �������
    {
        ScoreCheck.text = ScoreManager.score.ToString();
    }
}
