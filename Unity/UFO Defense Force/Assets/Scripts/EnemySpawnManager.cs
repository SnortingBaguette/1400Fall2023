using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{

    public GameObject[] uFoPrefabs; //Array to store UFO ships
    public int ufoIndex;
    private float spawnRangeX = 25f;
    private float spawnPosZ = 20f;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomUFO () 
    {
        Vector3 spawnPositions = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        ufoIndex = Random.Range(0, uFoPrefabs.Length); //Picks a random UFO from the array
        Instantiate(uFoPrefabs[ufoIndex], spawnPositions, uFoPrefabs[ufoIndex].transform.rotation); //Instantiate the indexed UFO from the Array on the random X interval
    }
}
