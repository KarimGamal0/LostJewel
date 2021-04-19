using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondCollector : MonoBehaviour
{
    [SerializeField] IntSO diamond;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Diamond"))
        {
            diamond.value ++;
            Destroy(other.gameObject);
        }
    }
}
