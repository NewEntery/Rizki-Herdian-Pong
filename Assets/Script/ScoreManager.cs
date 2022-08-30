using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int rightScore;
    public int leftScore;
    public int maxScore;

    public BallControler ball;

    public void addrightScore(int tambah)
    {

        leftScore += tambah;
        ball.Resetball();

        if (leftScore >= maxScore)

        rightScore += tambah;
        ball.Resetball();

        if (rightScore >= maxScore)

        {
            gameOver();
        }
    }

    public void addleftScore(int tambah)
    {

        rightScore += tambah;
        ball.Resetball();

        if (rightScore >= maxScore)

        leftScore += tambah;
        ball.Resetball();

        if (leftScore >= maxScore)

        {
            gameOver();
        }
    }

    public void gameOver()
    {
        SceneManager.LoadScene("Menu");
    }
}
