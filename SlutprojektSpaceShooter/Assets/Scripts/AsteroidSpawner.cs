using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public Transform[] Ast_Spawner;

    public GameObject Asteroid;
    public float timeBetweenWaves = 0.5f;
    public float timeToSpawn = 2f;
    // Update is called once per frame
    void Update()
    {

        if (Time.time >= timeToSpawn)
        {
            SpawnAsteroids();
            timeToSpawn = Time.time + timeBetweenWaves;
        }

    }

    void SpawnAsteroids()
    {
        float spawnPossitionX = Random.Range(-2.5f, 2.1f);
        float spawnPossitionY = Random.Range(6f, 6.5f);
        Vector3 asteroidSpawnPos = new Vector3(spawnPossitionX, spawnPossitionY);

        Instantiate(Asteroid, asteroidSpawnPos, Quaternion.identity);
        
    }
}
