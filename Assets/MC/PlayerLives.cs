using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{

    public int lives = 3;

    void Start()
    {
        
    }


    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If it touches it destroys both the player and enemy
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            lives -= 1;
            if (lives <= 0)
            {
                Destroy(gameObject);
            } 
        }
    }

}
