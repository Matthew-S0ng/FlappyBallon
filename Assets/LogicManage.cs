 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManage : MonoBehaviour
{
    public int playerScore = 0;
    public int highScore;
    public Text score;
    public Text highScoreText;
    public GameObject GameOver;
    [SerializeField] private AudioSource ding;
    public Balloon balloon;

    void Start()
    {
        balloon = GameObject.FindGameObjectWithTag("ballon").GetComponent<Balloon>();
    }


    [ContextMenu("Increase Score")]
    public void addScore()
    {
        if(balloon.ballisAlive == true)
        {
            playerScore += 1;
            score.text = playerScore.ToString();
            ding.Play();
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
