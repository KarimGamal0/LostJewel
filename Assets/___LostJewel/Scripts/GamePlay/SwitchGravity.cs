using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Created by Karim Gamal 7:30 Am
public class SwitchGravity : MonoBehaviour
{
    [SerializeField] InputManager _inputManager;
    [SerializeField] PlayerData _vector;
    [SerializeField] BoolSO isdead;
    bool top = false;

    void Update()
    {
        if (_inputManager.KeyGravity()||(isdead.state==true&&_vector.gravityScale<0))
        {
            Rotation();
            FlipGravity();
        }
    }

    void FlipGravity()
    {
        _vector.gravityScale *= -1;
        _vector.jumpForce *= -1;
    }

    void Rotation()
    {
        if (top == false)
        {
            transform.eulerAngles = new Vector3(0, 180, 180);
        }
        else
        {
            transform.eulerAngles = Vector3.zero;
        }
        top = !top;
    }
}