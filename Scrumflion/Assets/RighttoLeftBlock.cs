using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RighttoLeftBlock : MonoBehaviour
{
    [SerializeField] List<GameObject> blockPrefabs;
    [SerializeField] Transform playerTransform;
    [SerializeField] float spawnTime = 4f;
    [SerializeField] float spawnDistance = 5;
    public float timer = 4;
  
    void SpawnBlock()
    {
        Vector3 spawnPos = playerTransform.position + new Vector3(spawnDistance, 0.75f, 0); // Adjust spawn position to the right
        GameObject block = Instantiate(blockPrefabs[Random.Range(0, blockPrefabs.Count)], spawnPos, Quaternion.identity);
        Destroy(block, 10);
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
