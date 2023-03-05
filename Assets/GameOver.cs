using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;

    private void gameOver()
    {
        
        gameOverUI.SetActive(true);
    }

    public void restart()
    {
        SceneManager.LoadScene(2);
    }
}