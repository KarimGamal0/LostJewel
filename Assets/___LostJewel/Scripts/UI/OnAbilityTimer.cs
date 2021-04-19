using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class OnAbilityTimer : MonoBehaviour
{
    public static OnAbilityTimer onAbilityEvent;

    private void Awake()
    {
        onAbilityEvent = this;
    }
    public event Action onAbilityMoodEnter;
    public void AbilityMoodEnter()
    {
        if (onAbilityMoodEnter != null)
        {
            onAbilityMoodEnter();
        }
    }

}
