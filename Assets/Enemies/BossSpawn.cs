using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawn : MonoBehaviour
{
    public GameObject Boss; // Prefab for the boss enemy
    public GameObject GameOver; // GameOver object
    private float timer = 0f; // Timer to track time
    private bool bossSpawned = false; // Flag to ensure the boss is spawned only once
    private GameObject currentBoss; // Reference to the instantiated boss
    public GameObject enemies;

    void Start()
    {
        // Ensure GameOver is initially hidden
        GameOver.SetActive(false);
    }

    void Update()
    {
        // Increment the timer by the time passed in each frame
        timer += Time.deltaTime;

        // Check if 2 minutes (120 seconds) have passed
        if (timer >= 120f && !bossSpawned)
        {
            SpawnBoss();
        }

        // Check if the boss has been destroyed (i.e., if the reference is null)
        if (currentBoss == null && bossSpawned)
        {
            ActivateGameOver();
        }
    }

    // Method to spawn the boss
    void SpawnBoss()
    {
        // Instantiate the boss at the position of the BossSpawn object
        currentBoss = Instantiate(Boss, transform.position, Quaternion.identity);

        // Set the flag to true to prevent multiple spawns
        bossSpawned = true;
    }

    // Method to activate GameOver
    void ActivateGameOver()
    {
        GameOver.SetActive(true);

        GameObject[] clones = GameObject.FindGameObjectsWithTag("Clone");
        foreach (GameObject clone in clones)
        {
            Destroy(clone);
        }

        enemies.SetActive(false);
        return;
    }
}
