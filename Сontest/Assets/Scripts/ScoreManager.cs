using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;

    private Text ScoreTxt;

    void Start()
    {
        ScoreTxt = GetComponent<Text>();
    }

    void Update()  //����� ������� � ����������� �����
    {
        ScoreTxt.text = score.ToString();
    }
}
