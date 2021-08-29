using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : Singleton<ScoreController>
{
    public Text myScores;
    public int scoreNum;


    // Start is called before the first frame update
    void Start()
    {
        scoreNum = 0;
        UpdateScore();

    }
    private void FixedUpdate()
    {
        
    }
    public void AddScore(int newScore)
    {
        scoreNum += newScore;
        UpdateScore();
    }
    void UpdateScore()
    {
        myScores.text = "Score: " + scoreNum;
    }
}
