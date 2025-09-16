using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    int score = 0;
    bool gameOver = false;
    public static GameManager instnace;
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] TextMeshProUGUI ScoreDisplay;
    [SerializeField] GameObject PlayerTwo;
    [SerializeField] GameObject PlayerOne;
    [SerializeField] GameObject meteor;
    bool player2spawn = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake() {
       instnace = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver && Input.GetKeyDown(KeyCode.R)){
          SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(score >= 200 && player2spawn == false){
            Debug.Log("Player 2 Spawned");
            //works
            Instantiate(PlayerTwo, new Vector3(-0.01f, -7.96f, -0.01f), Quaternion.identity);
            player2spawn = true;
        }
        if (score >= 1)
        {
           float randomnum = Random.Range(0,300);
            if (randomnum == 1)
            {
                int randomx = Random.Range(-5, 6);
                int randomy = Random.Range(-2, 2);
                Instantiate(meteor, new Vector3(randomx, randomy, -0.01f), Quaternion.identity);
                player2spawn = true;
            }
        }
    }
    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        ScoreDisplay.text = "Score: " + score.ToString();
    }
    public int GetScore()
    {
        return score;
    }

    public bool GetBool()
    {
        return gameOver;
    }
    public void GameOver()
    {
        gameOver = true;
        gameOverScreen.SetActive(true);
    }
}
