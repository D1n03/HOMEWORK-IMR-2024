using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public int score;
    public GameObject holeObject;
    HoleBehavior holeBehavior;
    public GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        holeBehavior = holeObject.GetComponent<HoleBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        score = holeBehavior.GetScoreCount();
        scoreText.GetComponent<ScoreManager>().SetScoreCount(score);
    }
}
