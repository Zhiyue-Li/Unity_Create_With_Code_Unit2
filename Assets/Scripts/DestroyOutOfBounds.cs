using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    float upperBound = 35f;
    float lowerBound = -15f;
    float leftBound = -25f;
    float rightBound = 25f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > upperBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            // ScoreCalculator.score -= 1;
            Destroy(gameObject);
        }
        else if (transform.position.x < leftBound)
        {
            // ScoreCalculator.score -= 1;
            Destroy(gameObject);
        }
        else if (transform.position.x > rightBound)
        {
            // ScoreCalculator.score -= 1;
            Destroy(gameObject);
        }
    }
}
