using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoorActivator : MonoBehaviour
{
    [SerializeField] IntSO Keys;
    [SerializeField] OnCollectGameEvent collect;
    private void Start()
    {
        Keys.value = 0;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("key"))
        {
            other.GetComponent<Animator>().SetTrigger("PlayerOn");
            other.transform.GetChild(0).GetComponent<Animator>().SetTrigger("SwitchOn");
            other.transform.GetChild(0).gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            Keys.value++;
        }
    }
}
