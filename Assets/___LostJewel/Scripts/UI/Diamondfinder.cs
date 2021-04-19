using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Diamondfinder : MonoBehaviour
{
    [SerializeField] IntSO diamond;
    [SerializeField] Image diamondimage;
    [SerializeField] Image winpanel;
    Color diamondcolor = Color.white;
    private void Start()
    {
        diamond.value = 0;
    }
    void Update()
    {
        if (diamond.value == 0)
        {
            diamondcolor.a = 0.5f;
            winpanel.gameObject.SetActive(false);
            diamondimage.color = diamondcolor;
        }
        else
        {
            diamondcolor.a = 1.0f;
            winpanel.gameObject.SetActive(true);
            diamondimage.color = diamondcolor;
            Time.timeScale = 0.0f;
            StartCoroutine(Waiter());
        }
        IEnumerator Waiter()
        {
            yield return new WaitForSecondsRealtime(5);
            Time.timeScale = 1.0f;
            SceneManager.LoadScene("Level2");
        }
    }
}

