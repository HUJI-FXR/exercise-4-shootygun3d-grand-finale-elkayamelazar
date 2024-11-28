using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreScript : MonoBehaviour
{
    private int highScore = 0; 
    [SerializeField] private ScoreScript scoreScript;
    [SerializeField] GameObject win;
    [SerializeField] GameObject lose;
    private TextMeshProUGUI highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreScript = FindObjectOfType<ScoreScript>();

        // Get the TextMeshPro component attached to the HighScoreText GameObject
        highScoreText = GetComponent<TextMeshProUGUI>();

        // Load the high score from PlayerPrefs
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
        }

        UpdateHighScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreScript != null && scoreScript.score > highScore)
        {
            highScore = scoreScript.score;
            PlayerPrefs.SetInt("HighScore", highScore); 
            UpdateHighScoreText(); 
        }
    }

    private void UpdateHighScoreText()
    {
 
        highScoreText.text = "High Score: " + highScore;
    }

    public void SaveHighScore()
    {
        Debug.Log(highScore + " " + scoreScript.score);
        if (scoreScript != null && scoreScript.score > highScore)
        {
            highScore = scoreScript.score;
            PlayerPrefs.SetInt("HighScore", highScore);
            UpdateHighScoreText(); 
        }
    }

    public void GameEndMassage(int flag)
    {
        if (flag ==1)
        {
            win.SetActive(true);
        }
        else if(flag == 0)
        {
            lose.SetActive(true);
        }
    }
}
