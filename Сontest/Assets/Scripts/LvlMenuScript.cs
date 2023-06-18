using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlMenuScript : MonoBehaviour
{
    public void OnFirstLvlButton()
    {
        SceneManager.LoadScene(2);
    }
    public void OnSecondLvlButton()
    {
        SceneManager.LoadScene(3);
    }
    public void OnThirdLvlButton()
    {
        SceneManager.LoadScene(4);
    }
    public void OnFourthLvlButton()
    {
        SceneManager.LoadScene(5);
    }
    public void OnFifthLvlButton()
    {
        SceneManager.LoadScene(6);
    }
}
