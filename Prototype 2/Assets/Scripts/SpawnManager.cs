using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeXorZreally = 20;
    private float spawnPosZorXreally = -20;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;


    void Start() 
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();   
        }*/
    }
    void SpawnRandomAnimal()
    {
        
        Vector3 spawnPos = new Vector3(spawnPosZorXreally, 0,
          Random.Range(spawnRangeXorZreally - 20, spawnRangeXorZreally));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        
        Instantiate(animalPrefabs[animalIndex], spawnPos,
        animalPrefabs[animalIndex].transform.rotation);
        
    }
}
