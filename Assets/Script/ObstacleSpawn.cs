using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float TimeBetweenSpawn;
    public float SpawnTime;
    public float obstacleRadius = 0.5f; 
   
    void Update()
    {
        if (Time.time > SpawnTime)
        {
            Spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
        }
    }

    void Spawn()
    {
        Vector3 spawnPosition;
        bool positionIsValid = false;

        do
        {
            float X = Random.Range(minX, maxX);
            float Y = Random.Range(minY, maxY);
            spawnPosition = transform.position + new Vector3(X, Y, 0);

            Collider2D[] colliders = Physics2D.OverlapCircleAll(spawnPosition, obstacleRadius);

            if (colliders.Length == 0)
            {
                positionIsValid = true;
            }

        } while (!positionIsValid);

        Instantiate(Obstacle, spawnPosition, transform.rotation);
    }
}
