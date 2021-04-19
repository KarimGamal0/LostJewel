using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSave : MonoBehaviour
{
    [SerializeField] PlayerData playerpositionData;
    [SerializeField] PlayerData savepositionData;
    private void Start()
    {
        savepositionData.movement=new Vector2(0,0);
        savepositionData.position = new Vector2(0, 0);
        savepositionData.gravityScale =1.0f;
        savepositionData.speed = 10.0f;
        savepositionData.jumpForce = 15.0f;
        savepositionData.isGrounded = false;
}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            savepositionData.position = playerpositionData.position;
            savepositionData.movement = playerpositionData.movement;
        }
    }
}
