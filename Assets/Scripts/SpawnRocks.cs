using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRocks : MonoBehaviour
{
    public GameObject rock;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    public float timeBetweenEachSpawn;
    private float spawnTime;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenEachSpawn;
        }

    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(rock, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }

}
