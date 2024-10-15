using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Reference your TextMeshPro object here

    public void UpdateScoreUI(int newScore)
    {
        scoreText.text = "Score: " + newScore;
    }
}
