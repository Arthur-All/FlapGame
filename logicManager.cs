using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicManager : MonoBehaviour
{
    public int playerScore;
    public Text score;
    public GameObject gameOverScreen; 

    [ContextMenu("Incraese score")]
    public void addScore(int scoreAdd)
    {
        playerScore +=  scoreAdd;
        score.text = playerScore.ToString();
    }

    public void restratGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

}