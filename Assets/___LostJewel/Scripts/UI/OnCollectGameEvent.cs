using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class OnCollectGameEvent : MonoBehaviour
{
    public static OnCollectGameEvent onCollectEvent;
    public event Action onCollectItems;

    private void Awake()
    {
        onCollectEvent = this;
    }

    public void CollectItems()
    {
        if (onCollectItems != null)
        {  
            onCollectItems();
        }
    }

}
