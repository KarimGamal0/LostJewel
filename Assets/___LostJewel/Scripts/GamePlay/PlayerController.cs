using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Created by Karim Gamal 7:30 Am
public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerData _vector;
    [SerializeField] Rigidbody2D _rb2d;

    [SerializeField] InputManager _inputManager;

    Animator anim;

    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        if (_vector.gravityScale < 0)
        {
            _vector.gravityScale *= -1;
        }
    }

    void Update()
    {
        if(_vector.isGrounded==true)
        {
            anim.SetBool("Grounded", true);
        }
        else
        {
            anim.SetBool("Grounded", false);
        }
        anim.SetFloat("movementX", _vector.movement.x);
        anim.SetFloat("movementY", _vector.movement.y);
    }


    void FixedUpdate()
    {
        _rb2d.velocity = _vector.movement;
        _rb2d.gravityScale = _vector.gravityScale;
    }
}
