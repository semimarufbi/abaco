using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rigidbody2D;
    float direction;
    float speed = 20; 
    
   void Move()
    {
        rigidbody2D.velocity =  new Vector2 (direction * speed, 0);
     if(transform.position.x < 0) 
        {
            transform.position = new Vector2(-GameManager.instance.ScreenBounds.x,transform.position.y);
        }
    }
    private void Update()
    {
        direction = Input.GetAxis("Horizontal");
        Move();
    }






}
