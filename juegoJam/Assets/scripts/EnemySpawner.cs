using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemy;
    public float timeBetweenRespawn = 2f;
    private float timeRespawnLeft;
    // Start is called before the first frame update
    void Start()
    {
        timeRespawnLeft = timeBetweenRespawn;
    }

    // Update is called once per frame
    void Update()
    {
        //spawnear enemigo en un spawn point random
        timeRespawnLeft -= Time.deltaTime;
        for(int i=0; i<spawnPoints.Length; ++i)
        {
            if (timeRespawnLeft <= 0)
            {
                Instantiate(enemy, spawnPoints[i].position, spawnPoints[i].rotation);
                timeRespawnLeft = timeBetweenRespawn;
            }
        }
    }
}
