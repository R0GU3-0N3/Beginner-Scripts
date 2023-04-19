using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public GameObject[] powerupPrefabs;
    
    private float spawnRangeX = 20f;

    private float spawnPosZ = 20f;

    private float startDelay = 5f;

    private float spawnInterval = 5f;
    void Start()
    {
        InvokeRepeating("SpawnPowerup", startDelay, spawnInterval);
    }

    void Update()
    {

    }
    
    void SpawnPowerup()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int powerupIndex = Random.Range(0,powerupPrefabs.Length);
        Instantiate(powerupPrefabs[powerupIndex],spawnPos, powerupPrefabs[powerupIndex].transform.rotation);
    }
}
