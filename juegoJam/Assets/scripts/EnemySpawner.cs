using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemyStone;
    public GameObject enemyFire;
    public GameObject enemyMetal;
    private GameObject enemy;
    int r2 = 0;
    public float timeBetweenRespawn = 2f;
    private float timeRespawnLeft;
    
    int cnt = 0;
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

        int r = Random.Range(0, spawnPoints.Length - 1);
        if (timeRespawnLeft <= 0)
        {
            r2 = Random.Range(0, 2);
            if(r2 == 0)
            {
                enemy = enemyFire;
            }
            else if(r2 == 1)
            {
                enemy = enemyMetal;
            }
            else if (r2 == 2)
            {
                enemy = enemyStone;
            }
            Instantiate(enemy, spawnPoints[r].position, spawnPoints[r].rotation);
            //  AudioManager.instance.PlayTraslation();
            timeRespawnLeft = timeBetweenRespawn;
        }

        //if (timeRespawnLeft <= 0)
        //{
        //    Instantiate(enemy, pointPrueba.transform.position, pointPrueba.transform.rotation);
        //    timeRespawnLeft = timeBetweenRespawn;
        //}


    }
}
