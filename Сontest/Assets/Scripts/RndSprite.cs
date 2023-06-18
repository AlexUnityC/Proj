using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RndSprite : MonoBehaviour
{

    public int rnd = 0;

    public Sprite[] Sprite_Pic;

    public Sprite Num()  //вывод случайной картинки из массива Sprite_Pic
    {
        rnd = Random.Range(0, Sprite_Pic.Length);
        GetComponent<SpriteRenderer>().sprite = Sprite_Pic[rnd];
        return Sprite_Pic[rnd];
    }
}
