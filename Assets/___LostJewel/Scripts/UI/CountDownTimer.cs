using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class CountDownTimer : MonoBehaviour
{
    public GameObject YouLoseMenuUI;
    [SerializeField] BoolSO YouLose;
    [SerializeField] TMP_Text timerText;
    [SerializeField]float currentTime=0f;
    [SerializeField]float startingTime=10f;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        YouLoseMenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime; //decrease it by one each sec not frame

        // print(currentTime);
        timerText.text = currentTime.ToString("0");
        if (currentTime <= 0)
        {
            //here time over 
            //game over

            currentTime = 0;

            YouLoseMenuUI.SetActive(true);
            Time.timeScale = 0.0f;
            YouLose.state = true;

        }
    }
}
