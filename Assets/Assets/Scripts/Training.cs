using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Training : MonoBehaviour
{
    public GameObject prefab;
    public float spawnDelay;
    private float currentSpawnDelay;


    void Start()
    {
        currentSpawnDelay = spawnDelay;
    }

    void Update()
    {
         currentSpawnDelay -= Time.deltaTime;
         if (currentSpawnDelay < 0)
         {
             currentSpawnDelay = spawnDelay;
             var randomPosition = Random.Range(-8f, 8f);
             Instantiate(prefab, new Vector3(randomPosition, 13, 0), Quaternion.identity);

         }
    }
}
