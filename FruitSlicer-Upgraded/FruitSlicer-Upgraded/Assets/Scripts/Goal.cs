using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    
    public int timeLeft = 10;
    public Text countdown;
   
    void Start()
    {
        
        StartCoroutine("LoseTime");
        Time.timeScale = 1;
    }
    void Update()
    {
        countdown.text = ("" + timeLeft);
        if (Score.CurrentScore == 500)
        {
           
            StartCoroutine(WaitForSceneLoad());
        }
    }
    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
            if (timeLeft < 0)
            {
                
                yield return new WaitForSeconds(3);
                SceneManager.LoadScene(2);
                break;
            }
        }
    }
    void OnTriggerEnter2D()
    {
        Score.CurrentScore += 100;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);

    }

}
