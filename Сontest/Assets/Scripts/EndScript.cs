using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    public void OnPlayAgainButton()
    {
        SceneManager.LoadScene(Managment.Lvl+1);
        ScoreManager.score = 0;
    }

    public void OnExitToMenuButton()
    {
        SceneManager.LoadScene(0);
        ScoreManager.score = 0;
    }
}
