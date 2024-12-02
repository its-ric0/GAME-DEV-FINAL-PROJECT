using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> cannonBallPrefab;
    [SerializeField] Transform cannonTransform;
    [SerializeField] float spawnTime = 1f;
    [SerializeField] float spawnDistance;

    public float timer = 3;

   void SpawnCannonBall()
   {
        Vector3 spawnPos = new Vector3(61.5f, -16f, 0f);
        GameObject CannonBall = Instantiate(cannonBallPrefab[Random.Range(0, cannonBallPrefab.Count)], spawnPos, Quaternion.identity);
        Destroy(CannonBall, 5);
   }

    
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnTime)
        {
            SpawnCannonBall();
            timer = 0;
        }
    }
}
