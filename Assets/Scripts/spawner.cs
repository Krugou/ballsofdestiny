using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject knightPrefab; // Assign your BlackCubeKnightMovement Prefab in the inspector
    public int numberOfKnights = 10; // Number of knights to spawn
    public Vector3 spawnRange = new Vector3(10, 0, 10); // Range within which to spawn the knights

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfKnights; i++)
        {
            // Generate a random position within the spawn range
            Vector3 spawnPosition = new Vector3(
                Random.Range(-spawnRange.x, spawnRange.x),
                0,
                Random.Range(-spawnRange.z, spawnRange.z)
            );

            // Instantiate a new knight at the spawn position
            Instantiate(knightPrefab, spawnPosition, Quaternion.identity);
        }
    }
}