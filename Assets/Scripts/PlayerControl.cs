using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerControl : MonoBehaviour
{
    
    public static event Action <float> OnPlayerDamaged;
    //public LayerMask _ground;
    //public bool isGrounded;
    public float _speedX;
    private float _horizontal;


    Rigidbody2D _compRigidBody;

    void Awake()
    {
        _compRigidBody = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
       // Movement();
       
        // transform.position = new Vector2(transform.position.x + _horizontal * _speedX * Time.deltaTime,0);
        //_jump = Input.GetAxisRaw("Jump");
    }
    void FixedUpdate()
    {
        _compRigidBody.velocity = new Vector2(_horizontal * _speedX, 0);
       
    }
    
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.tag == "littleEnemy")
        {
            OnPlayerDamaged?.Invoke(0.5f);
            
        }
        else if (collision.gameObject.tag == "capsuleEnemy")
        {
            OnPlayerDamaged?.Invoke(0.8f);
            
        }
        else if (collision.gameObject.tag == "hexagon")
        {
            OnPlayerDamaged?.Invoke(3f);
        }

    }

   
}
