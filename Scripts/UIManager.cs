using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    int score = 0;

    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI highscoreText;

    void Start() 
    {
        highscoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void AddScore() 
    {
        score++;

        scoreText.text = score.ToString();

        if(score >= PlayerPrefs.GetInt("HighScore", 0)) {
            PlayerPrefs.SetInt("HighScore", score);
            highscoreText.text = score.ToString();
        }
        
    }

    public void Update()
    {
        
        if(score >= 20)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }
        
    }

    public void Reset() 
    {
        PlayerPrefs.DeleteKey("HighScore");
        highscoreText.text = "0";
    }
}
