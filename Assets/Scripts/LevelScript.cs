using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public Text lifeText;
    public GameObject gameOverScreen;
    private bool gameOver = false;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        if (!gameOver)
        {
            playerScore += 1;
            scoreText.text = playerScore.ToString();
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void setLifes(int life)
    {
        lifeText.text = life.ToString();
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void setGameOver()
    {
        gameOver = true;
        gameOverScreen.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
