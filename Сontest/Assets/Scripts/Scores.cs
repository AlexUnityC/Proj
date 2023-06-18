using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Scores : MonoBehaviour
{
    public RndSprite abc;

    private bool click = false;

    public Sprite Img;

    private int b = 0;

    private bool Col = false;

    private bool imgEquals = false;

    public UnityEvent OnClick;

    private void Start()
    {
        abc.Num();
    }

    void OnCollisionStay2D(Collision2D other)  //���� ������ � ����� Player ������� � ������� �� ������, �� ���������� Col ������� ������������ ��� ������������ ������ Num � ���������� ���� ����� true
    {
        if (other.gameObject.CompareTag("Player") && click)
        {
            Col = true;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))  //��� ��������� if ������� ������ ���������� click ������ true ��� ������� � false ��� ������� ����� ����� ����� ������ ���� ������ ������� �� ������� ��� ���������� �����
        {
            click = true;
            OnClick.Invoke(); //������������ ����� ����� �����
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            click = false;
        }

        b = abc.rnd;

        if (Img.name == abc.Sprite_Pic[b].name)
        {
            imgEquals = true;
        }

        if (imgEquals)  //���� ���������� imgEqual, Col � click ����� true, �� ����������� ����� Num ������� ������� �������� ������� ���� �����, � ������������ ���� ����
        {
            if (Col)
            {
                if (click)
                {
                    Col = false;
                    click = false;
                    imgEquals = false;
                    abc.Num();
                    ScoreManager.score += 1;
                }
            }
        }

        if(Col)
        {
            if (click)
            {
                if (Img.name != abc.Sprite_Pic[b].name)  //���� ����� �������� �� �������, ������� ���������� �� ���� ��� ���� �����, 1 ���� ��������� � �����
                {
                    ScoreManager.score -= 1;
                }
                click = false;
            }
            Col = false;
        }
    }
}
