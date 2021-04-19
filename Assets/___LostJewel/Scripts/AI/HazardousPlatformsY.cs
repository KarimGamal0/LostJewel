using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardousPlatformsY : MonoBehaviour
{ 
    [SerializeField] BoolSO isDead;

    private Vector2 startPosition;
    private Vector2 newPosition;
    [SerializeField] private int speed = 3;
    [SerializeField] private int maxDistance = 1;

    void Start()
    {
        isDead.state = false;
        startPosition = transform.position;
        newPosition = transform.position;
    }

    void Update()
    {
        newPosition.y = startPosition.y + (maxDistance * Mathf.Cos(Time.time * speed));
        transform.position = newPosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider)
        {
            if (collision.collider.CompareTag("Player"))
            {
                isDead.state = true;
            }
        }
    }  
}
