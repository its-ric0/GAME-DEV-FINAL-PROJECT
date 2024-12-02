using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//THIS SCRIPT SPAWNS BLOCK THAT FALL FROM THE TOP OF THE SCREEN ALL THE WAY DOWN.
public class BlockSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> blockPrefabs;
    [SerializeField] Transform playerTransform;
    [SerializeField] float spawnTime = 2f;
    [SerializeField] float spawnDistance = 30;
    public float timer = 6;
    
    void SpawnBlock()
    {
        Vector3 spawnPos = playerTransform.position + new Vector3(0.0f, 0.75f, 0).normalized * spawnDistance;
        GameObject Blocks = Instantiate(blockPrefabs[Random.Range(0, blockPrefabs.Count)], spawnPos, Quaternion.identity);
        Destroy(Blocks, 8);
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnTime)
        {
            SpawnBlock();
            timer = 0;
        }
    }
}
