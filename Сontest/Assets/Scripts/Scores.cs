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

    void OnCollisionStay2D(Collision2D other)  //если объект с тегом Player навелся и кликнул на объект, то переменная Col которая понадобиться для срабатывания метода Num и зачисления очка равна true
    {
        if (other.gameObject.CompareTag("Player") && click)
        {
            Col = true;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))  //два оператора if которые делают переменную click равной true при нажатии и false при отжатии мышки нужны чтобы нельзя было просто навести на объекты для зачисления очков
        {
            click = true;
            OnClick.Invoke(); //срабатывание звука клика мышки
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

        if (imgEquals)  //если переменные imgEqual, Col и click равны true, то срабатывает метод Num который сменяет картинку которую надо найти, и прибавляется одно очко
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
                if (Img.name != abc.Sprite_Pic[b].name)  //если игрок попадает по объекту, который отличается от того что надо найти, 1 очко снимается с счета
                {
                    ScoreManager.score -= 1;
                }
                click = false;
            }
            Col = false;
        }
    }
}
