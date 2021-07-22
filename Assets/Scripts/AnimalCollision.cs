using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalCollision : MonoBehaviour
{
    public Slider hp;
    public int maxHP = 3;
    // Start is called before the first frame update
    void Start()
    {
        hp.maxValue = maxHP;
        hp.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp.value >= maxHP)
        {
            Destroy(gameObject);
            ScoreCalculator.score += 1;
            Debug.Log("Score: " + ScoreCalculator.score);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            hp.value += 1;
        }
        else
        {
            ScoreCalculator.score -= 1;
            Debug.Log("Score: " + ScoreCalculator.score);
        }
    }
}
