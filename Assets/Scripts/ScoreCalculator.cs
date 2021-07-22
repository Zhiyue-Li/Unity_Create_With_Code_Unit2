using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour
{
    public static int score = 0;

    void Update()
    {
        if (score < 0)
        {
            Debug.Log("Game Over");
            Time.timeScale = 0;
        }
    }
}
