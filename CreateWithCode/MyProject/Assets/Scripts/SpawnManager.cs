using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    private int count;
    private Vector3 spawnPos;
    private Transform[] spawnPoints;
    private int spawnIndex;

    private float enemySpawnTime = 3.0f;
    private float startDelay = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        count = transform.childCount;
        spawnPoints = new Transform[count];
        for (int i = 0; i < count; i++)
        {
            spawnPoints[i] = transform.GetChild(i);

        }

        InvokeRepeating("SpawnRandomEnemy", startDelay, enemySpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomEnemy()
    {
        spawnIndex = Random.Range(0, count);
        int randomIndex = Random.Range(0, enemies.Length);
        Instantiate(enemies[randomIndex], spawnPoints[spawnIndex].position, enemies[randomIndex].gameObject.transform.rotation);
    }
}
