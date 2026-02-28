using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyLife : MonoBehaviour
{
    public float lives = 3;
    public float shield = 3;
    public Image[] livesUI;
    public Image[] shieldUI;
    public GameObject player;
    public GameObject GameOver;
    public GameObject enemies;
    private GameObject targetObject;


    void Update()
    {
        if (lives <= 0)
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the enemy group hits the boundary
        if (collision.gameObject.CompareTag("Clone"))
        {
            // Reduce shield
            shield -= 1;

            // Update shield UI
            for (int i = 0; i < shieldUI.Length; i++)
            {
                shieldUI[i].enabled = i < shield;
            }

            // If the shield is depleted
            if (shield <= 0)
            {
                // Reduce lives only after resetting shield
                lives -= 1;

                // Update lives UI
                for (int i = 0; i < livesUI.Length; i++)
                {
                    livesUI[i].enabled = i < lives;
                }

                // Check if lives are depleted and destroy player
                if (lives <= 0)
                {
                    Destroy(player);
                }
                else
                {
                    // Reset shield for the next life
                    shield = shieldUI.Length;

                    // Reset shield UI for the new life
                    for (int i = 0; i < shieldUI.Length; i++)
                    {
                        shieldUI[i].enabled = true;
                    }
                }
            }
        }
    }
}
