using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject knightPrefab; // Assign your BlackCubeKnightMovement Prefab in the inspector
    public Vector3 spawnRange = new Vector3(10, 0, 10); // Range within which to spawn the knights
    public float spawnDelay = 5.0f; // Delay in seconds before spawning the knight

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnKnights", spawnDelay);
    }

    void SpawnKnights()
    {
        // Generate a random position within the spawn range
        Vector3 spawnPosition = new Vector3(
            Random.Range(-spawnRange.x, spawnRange.x),
            knightPrefab.transform.position.y, // Use the Y position from the prefab
            Random.Range(-spawnRange.z, spawnRange.z)
        );

        // Instantiate a new knight at the spawn position
        Instantiate(knightPrefab, spawnPosition, Quaternion.identity);
    }
}