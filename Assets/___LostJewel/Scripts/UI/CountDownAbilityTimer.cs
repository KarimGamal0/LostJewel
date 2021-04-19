using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CountDownAbilityTimer : MonoBehaviour
{
    private float currentTime = 0f;
    private float startingTime = 3f;


  // [SerializeField]
    TMP_Text text;
    void Start()
    {
        text.GetComponent<Text>();
 
        OnAbilityTimer.onAbilityEvent.onAbilityMoodEnter += OnCountDownAbilityTimer;
        
    }

    private void OnCountDownAbilityTimer()
    {      currentTime = startingTime;
  
        currentTime -= 1 * Time.deltaTime; //decrease it by one each sec not frame
        if (currentTime <= 0)
        {
            //here Go back to the normall gravity mood 
        }
    }
    private void OnDestroy()
    {
        OnAbilityTimer.onAbilityEvent.onAbilityMoodEnter -= OnCountDownAbilityTimer;
    }
}
