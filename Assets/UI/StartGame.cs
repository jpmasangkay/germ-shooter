using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject ui;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            player.SetActive(true);
            enemy.SetActive(true);
            ui.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
