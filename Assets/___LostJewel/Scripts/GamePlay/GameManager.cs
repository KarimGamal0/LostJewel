using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Gameplay Data
    [SerializeField] IntSO diamond;
    [SerializeField] IntSO keys;
    [SerializeField] IntSO score;
    [SerializeField] IntSO losecount;
    [SerializeField] BoolSO isdead;
    [SerializeField] BoolSO playerlost;
    [SerializeField] PlayerData playerdata;
    [SerializeField] PlayerData[] checkpoints;
    [SerializeField] GameObject player;
    [SerializeField] Vector2 playerstartingposition;
    //------------------------------------------------------------

    //player 
    [SerializeField] Animator playeranimator;
    //-------------------------------------------------------------

    //UI
    [SerializeField] Canvas mainmenu;
    [SerializeField] Canvas pausemenu;
    //-----------------------------------------------------------------
    private void Start()
    {
        playerstartingposition = player.transform.position;
        playerlost.state = false;
    }
    void Update()
    {
        Checkdead();
        if (playerlost.state == true)
        {
            CheckLose();
        }
    }

    private void CheckLose()
    {
        losecount.value++;
        StartCoroutine(Waiter());
    }
    IEnumerator Waiter()
    {
        yield return new WaitForSecondsRealtime(5);
        Time.timeScale = 1.0f;
        Debug.Log("beforeLoad");

        SceneManager.LoadScene(1);
        Debug.Log("AfterLoad");
    }


    private void Checkdead()
    {
        if (isdead.state == true)
        {
            //playeranimator.SetBool("die", true);
            StartCoroutine(Waitfordead());
        }
    }

    IEnumerator Waitfordead()
    {
        yield return new WaitForSecondsRealtime(2);
        foreach (var item in checkpoints)
        {
            if (item.position != Vector2.zero)
            {
                player.transform.position = item.position;
                isdead.state = false;
                //playerdata.gravityScale = -1.0f;
                break;
            }
            else
            {
                player.transform.position = playerstartingposition;
                isdead.state = false;
                //playerdata.gravityScale = -1.0f;
                break;
            }
            //playeranimator.SetBool("die", false);
        }
    }
}
