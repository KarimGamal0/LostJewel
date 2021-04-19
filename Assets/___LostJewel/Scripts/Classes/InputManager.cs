using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Created by Karim Gamal 7:30 Am
//edited by khattab 11.24pm fri
[CreateAssetMenu(fileName = "InputManager", menuName = "SO/Control/InputManager")]
public class InputManager : InputData
{
    [SerializeField] KeyCode _keyLeft;
    [SerializeField] KeyCode _keyRight;
    [SerializeField] KeyCode _keyGravity;
    [SerializeField] KeyCode _keyInteract;
    [SerializeField] KeyCode _keyJump;

    public override bool KeyLeft()
    {
        return Input.GetKey(_keyLeft);
    }

    public override bool KeyRight()
    {
        return Input.GetKey(_keyRight);
    }

    public override bool KeyGravity()
    {
        return Input.GetKeyDown(_keyGravity);
    }

    public override bool KeyInteract()
    {
        return Input.GetKeyDown(_keyInteract);
    }

    public override bool KeyJump()
    {
        return Input.GetKeyDown(_keyJump);
    }
}
