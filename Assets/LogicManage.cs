 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManage : MonoBehaviour
{
    public int playerScore = 0;
    public Text score;
    public GameObject GameOver;
    [SerializeField] private AudioSource golfclap;

     [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore = playerScore + 1;
        score.text = playerScore.ToString();

        if(playerScore % 5 == 0)
        {
            golfclap.Play();
        }

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
