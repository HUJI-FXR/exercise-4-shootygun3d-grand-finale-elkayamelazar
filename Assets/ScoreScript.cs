using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] public int score = 0; 
    private float comboTimer = 0f; 
    private float comboBonus = 10f;

    private TextMeshProUGUI scoreText;

   
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        comboTimer += Time.deltaTime;
    }

    public void AddScore()
    {
       
        float points = 1f + (comboBonus / Mathf.Max(comboTimer, 0.1f)); 
        score += Mathf.RoundToInt(points);
        
        comboTimer = 0f;

        
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
       
        scoreText.text = "Score: " + score;
    }
}
