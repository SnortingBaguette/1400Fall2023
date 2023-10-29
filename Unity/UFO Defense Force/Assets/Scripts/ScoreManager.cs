using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score; //Keep the score value
    public TextMeshProUGUI scoreText; //Visual text element to be modified

    public void IncreaseScore(int amount) //Called when the score is increased
    {
        score += amount;
        UpdateScoreText();
    }

    public void DecreaseScore(int amount) //Called when the score is decreased
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText() //Update the score in the UI
    {
        scoreText.text = "Score: " + score;
    }

}
