using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Created by Karim Gamal 7:30 Am
public abstract class InputData : ScriptableObject
{
    public abstract bool KeyRight();

    public abstract bool KeyLeft();

    public abstract bool KeyGravity();

    public abstract bool KeyInteract();

    public abstract bool KeyJump();
}
