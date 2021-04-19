using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Humiliateplayer : MonoBehaviour
{
    [SerializeField] Text losingtext;
    [SerializeField] IntSO losingcount;
    void Update()
    {
        losingtext.text = $"youLose!!!/n you died  " + losingcount.value;
    }
}
