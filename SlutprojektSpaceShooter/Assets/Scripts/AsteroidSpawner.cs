using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Detta script instantiatar asteroider till spelet
public class AsteroidSpawner : MonoBehaviour
{
    
    public GameObject Asteroid;
    public float timeBetweenWaves = 0.5f; //hur lång tid det ska vara mellan varje spawn av asteroider
    public float timeToSpawn = 2f; //hur långt inn i spelet första asteroiden ska spawnas, detta värde är det som gämförs med time.Time för att se om det är dags för en ny asteroid
    
    

    void Update()
    {

        if (Time.time >= timeToSpawn) //om tiden i spelet är större eller lika med värdet på timeToSpawn, instansieras en ny asteroid.
        {
            SpawnAsteroids(); //se nedan
            timeToSpawn = Time.time + timeBetweenWaves; //det nya värdet på time to spawn är nu den nuvarande tiden i spelet adderat med delayen mellan varje spawn
        }

    }

    void SpawnAsteroids() //Denna metod instantiatar en asteroid i ett plane som deklareras nedan
    {
        float spawnPossitionX = Random.Range(-2.5f, 2.1f); //brädden på spawn planet
        float spawnPossitionY = Random.Range(6f, 6.5f); //längden på spawn planet
        Vector3 asteroidSpawnPos = new Vector3(spawnPossitionX, spawnPossitionY);

        Instantiate(Asteroid, asteroidSpawnPos, Quaternion.identity);
        
    }
}
