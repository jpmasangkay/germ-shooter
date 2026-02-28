using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float moveSpeed = 5;

    void Start()
    {

    }

    void Update()
    {
        int enemyCount = transform.childCount;
        if (enemyCount <= 0 )
        {
            Destroy(gameObject);
        }
        // Move the enemy horizontally
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }

    // Check if the enemy hits the boundary, change direction
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Boundary"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
            moveSpeed *= -1; // Reverse movement direction
        }

        //If it reaches a certain point its dead
        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(gameObject);
        }

    }
}
