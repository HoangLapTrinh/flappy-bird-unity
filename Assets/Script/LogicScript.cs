using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text ScoreText;
    public GameObject GameOverScreen;

    [ContextMenu("Increase point")]
    public void addScore(int ScoreAdd)
    {
        playerScore = playerScore + ScoreAdd;
        ScoreText.text = playerScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
