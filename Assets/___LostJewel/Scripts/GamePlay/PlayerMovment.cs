using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Created by Karim Gamal 7:30 Am
public class PlayerMovment : MonoBehaviour
{
    [SerializeField] InputManager _inputManager;
    [SerializeField] PlayerData _vector;

    [SerializeField] float _speed;
    bool facingRight = true;


    void Start()
    {
        _speed = _vector.speed;
    }

    void Update()
    {
        Jump();
        Land();
        _vector.position = transform.position;
    }

    private void Land()
    {
        if (_vector.movement.y > 0 && _vector.isGrounded == false)
        {
            _vector.movement.y = 0.0f;
            _vector.gravityScale = 10;
        }
    }

    void FixedUpdate()
    {
        Move();
        FlipHorizontal();
    }


    void Jump()
    {
        if (_vector.isGrounded == true && _inputManager.KeyJump())
        {
            _vector.movement.y = _vector.jumpForce;
        }
    }


    void Move()
    {
        float direction = 0.0f;

        if (_inputManager.KeyLeft())
        {
            direction += _speed;
        }
        if (_inputManager.KeyRight())
        {
            direction -= _speed;
        }
        _vector.movement.x = direction;
    }
    void FlipHorizontal()
    {
        if (facingRight == false && _vector.movement.x > 0)
        {
            Flip();
        }
        else if (facingRight == true && _vector.movement.x < 0)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

}
