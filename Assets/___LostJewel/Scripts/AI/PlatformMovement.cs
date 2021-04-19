using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    private Vector2 startPosition;
    private Vector2 newPosition;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] private int speed = 3;
    [SerializeField] private int maxDistance = 5;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
        newPosition = transform.position;
    }

    void Update()
    {
        newPosition.x = startPosition.x + (maxDistance * Mathf.Sin(Time.time * speed));
        transform.position = newPosition;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider)
        {
            if (collision.collider.CompareTag("Player"))
            {
                collision.collider.transform.SetParent(transform);
                collision.collider.transform.GetComponent<Rigidbody2D>().position = rb.position;
            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider)
        {
            if (collision.collider.CompareTag("Player"))
            {
                collision.collider.transform.SetParent(null);
            }
        }
    }
}
