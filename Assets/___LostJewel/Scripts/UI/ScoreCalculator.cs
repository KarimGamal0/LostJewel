using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ScoreCalculator : MonoBehaviour
{
    public TMP_Text text;
    [SerializeField] IntSO scoreSO;
    private int score = 0;
    void Start()
    {
        text.GetComponent<Text>();
        OnCollectGameEvent.onCollectEvent.onCollectItems += OnIncreaseScore;
    }

    private void OnIncreaseScore()
    {
        score+=100;
        scoreSO.value = score;
        Debug.Log(score);
        text.text = score.ToString();
    }
}
