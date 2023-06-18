using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managment : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;

    public CursorMode cursorMode = CursorMode.Auto;

    public int LvlNum;

    public static int Lvl;

    private void Start()
    {
        Lvl = LvlNum; 
    }

    private void Update() //передача координат от мышки к объекту
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = pos;
    }
}
