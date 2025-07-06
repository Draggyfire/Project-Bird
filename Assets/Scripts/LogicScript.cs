using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public Text pressText;
    public GameObject gameOverScreen;
    public GameObject bird;
    public GameObject pipeSpawner;
    private bool gameIsStarted;

    void Update()
    {
        if (!gameIsStarted)
            if (Input.GetKeyDown(KeyCode.Space))
            {
                bird.GetComponent<BirdScript>().startGame();
                pipeSpawner.GetComponent<PipeSpawnScript>().startPipeSpawn();
                Destroy(pressText);
                scoreText.GetComponent<ScoreScript>().MakeTextVisible();
                gameIsStarted = true;
            }

    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        
        gameOverScreen.SetActive(true);
    }
}
