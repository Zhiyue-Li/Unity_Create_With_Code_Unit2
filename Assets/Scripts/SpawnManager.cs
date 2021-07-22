using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    int animalIndex;
    float zPos;
    float yPos = 0f;
    float xPos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnAnimal()
    {
        animalIndex = Random.Range(0, animalPrefabs.Length);
        xPos = Random.Range(-15f, 15f);
        zPos = Random.Range(-5f, 25f);
        Instantiate(animalPrefabs[animalIndex], new Vector3(xPos, yPos, 35f), animalPrefabs[animalIndex].transform.rotation);
        Instantiate(animalPrefabs[animalIndex], new Vector3(-25f, yPos, zPos), Quaternion.Euler(0f, 90f, 0f));
        Instantiate(animalPrefabs[animalIndex], new Vector3(25f, yPos, zPos), Quaternion.Euler(0f, -90f, 0f));
    }
}
