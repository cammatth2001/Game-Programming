using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;
public class CountDown : MonoBehaviour
{
    public int timeLeft = 60; 
    public Text countdown; 
    public Text Restart;
    void Start()
    {
        Restart.text = "";
        StartCoroutine("LoseTime");
        Time.timeScale = 1;
       
    }
    void Update()
    {
        countdown.text = ("" + timeLeft);
       
    }
    //Simple Coroutine
    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
            if (timeLeft < 0)
            {
                Restart.text = "Game Restarting";
                SceneManager.LoadScene(0);
                break;
            }
            

        }
    }
}