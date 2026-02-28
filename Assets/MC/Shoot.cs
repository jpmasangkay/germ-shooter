using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject pill;
    private int count = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        //Will make it so the projectile shoots and not rotate
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(pill, transform.position, Quaternion.identity);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If it touches it destroys both the projectile and enemy
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Boss")
        {
            Destroy(gameObject);
            count++;

            if (count == 3)
            {
                Destroy(collision.gameObject);
            }
        }

        //If it goes outside the bopundary at top the projectile will be destroyes so that it wont have 
        //a lot of clones in the game to not make it lag
        if (collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
    }

}
