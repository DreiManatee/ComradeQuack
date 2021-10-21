using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int spawnCount = 0;
    public int spawnAmount = 10;
    public float timeBetweenSpawns = 1.0f;
    public List<GameObject> path;

    float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = timeBetweenSpawns;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0f)
        {
            if (spawnCount < spawnAmount)
            {
                spawnCount++;
                var e = Instantiate(enemyPrefab, new Vector3(transform.position.x + Random.Range(-1.0f,1.0f), transform.position.y, transform.position.z + Random.Range(-1.0f, 1.0f)), Quaternion.identity, transform);
                e.GetComponent<EnemyMovement>().path = path;
            }
            
            spawnTimer = timeBetweenSpawns;
        }

        // for(int i = 0; i < spawnAmount; i++)
        // {
        //     spawnTimer -= Time.deltaTime;
        //     if (spawnTimer <= 0f)
        //     {
        //         for (int j = 0; j < spawnGroupCount; j++)
        //         {
        //             Instantiate(objectToSpawn, new Vector3(this.transform.position.x + Random.Range(-1.0f,1.0f), transform.position.y, 
        //                 transform.position.z + Random.Range(-1.0f, 1.0f)), Quaternion.identity, transform);
        //         }
        //         spawnTimer = timeBetweenSpawns;
        //     }
        // }

    }
}