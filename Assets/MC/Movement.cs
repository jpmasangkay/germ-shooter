using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 6; //Movement speed of white blood cell
    public float horizontalMovement; 

    void Start()
    {
        
    }

    void Update()
    {
        //This will make it move left and right
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * horizontalMovement * moveSpeed * Time.deltaTime);
    }
}
