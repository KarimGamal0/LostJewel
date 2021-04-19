using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Created by Karim Gamal 7:30 Am
//edited by khattab 11.24pm fri
[CreateAssetMenu(fileName ="PlayerData",menuName ="SO/Data/V2V")]
public class PlayerData : ScriptableObject
{
    public Vector2 movement=Vector2.zero;
    public Vector2 position;
    public float gravityScale = 1.0f;
    public float speed = 15.0f;
    public float jumpForce = 15.0f; 
    public bool isGrounded = false;
}
