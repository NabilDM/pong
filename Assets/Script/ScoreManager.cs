using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int rightScore;
    public int leftScore;

    public int maxScore;

    public BallControl ball;

    public void AddRightScore(int increment)
    {
        rightScore += increment;
        ball.ResetBall();

        if (rightScore >= maxScore)
        {
            GameOver();
        }
    }

    public void AddLefttScore(int increment)
    {
        leftScore += increment;

        if (leftScore >= maxScore)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Main_Menu");

    }
   
}
