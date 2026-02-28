using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemies;  // Prefab for normal enemies
    public float spawnDelay = 10f;  // Delay between spawns in seconds
    private float timer = 0f;   // Timer to track time since the last spawn
    private int roundCount = 0; // Counter for the number of rounds
    private bool bossSpawned = false;

    void Start()
    {
        timer = spawnDelay; // Initialize the timer so the first spawn happens immediately
    }

    void Update()
    {
        normalEnemy();
    }

    void normalEnemy()
    {
        timer += Time.deltaTime; // Increment the timer by the time elapsed since the last frame

        if (timer >= spawnDelay) // Check if the timer has reached the delay threshold
        {
            // Spawn the normal enemy
            GameObject clone = Instantiate(enemies, transform.position, Quaternion.identity);
            clone.tag = "Clone";
            Debug.Log("Spawned a clone with tag 'Clone'.");

            timer = 0f; // Reset the timer after spawning
        }
    }
}
