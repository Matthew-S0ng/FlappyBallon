using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManage : MonoBehaviour
{
    public int playerScore;
    public Text score;
    public GameObject GameOver;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore = playerScore + 1;
        score.text = playerScore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        GameOver.SetActive(true);
    }
    
}
