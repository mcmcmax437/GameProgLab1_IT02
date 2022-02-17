using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : MonoBehaviour
{
    [Header("Player velocity")]
    //Ox
    public int xVelocity = 2;
    // Oy
    public int yVelocity = 3;

    //
    private Rigidbody2D rigidBody;
    //========================================
    private void Start()
    {
        // 
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }
    //========================================
    private void Update()
    {
        updatePlayerPosition();
    }
    //=======================================


    private void updatePlayerPosition()
    {
        // 
        float moveInput = Input.GetAxis("Horizontal");
        // 
        float jumpInput = Input.GetAxis("Jump");

        // 

        if (moveInput < 0)
        { // 
            rigidBody.velocity = new Vector2(-xVelocity, rigidBody.velocity.y);
        }
        else if (moveInput > 0)
        { // 
            rigidBody.velocity = new Vector2(xVelocity, rigidBody.velocity.y);
        }

        if (jumpInput > 0)
        { //Тип прыгает
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, yVelocity);
        }
    }
}