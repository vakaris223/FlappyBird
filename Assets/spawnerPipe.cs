using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerPipe : MonoBehaviour
{
     public GameObject pipePrefab;
    public float spawnDelay = 2f;
    public float spawnPosition = 10f;
    
    private float spawnTimer = 0f;

    public float min, max;
    
    // Update is called once per frame
    void Update()
    {
        // Update the spawn timer
        spawnTimer += Time.deltaTime;
        
        // Spawn a pipe if the spawn timer exceeds the spawn delay
        if (spawnTimer >= spawnDelay)
        {
            SpawnPipe();
            spawnTimer = 0f;
        }
    }
    
    void SpawnPipe()
    {
        // Instantiate the pipe prefab
        GameObject pipe = Instantiate(pipePrefab);
        
        // Position the pipe at the spawn position
        pipe.transform.position = new Vector3(spawnPosition, Random.Range(min, max), 0f); //-1,5f 1,85f
    }
}
