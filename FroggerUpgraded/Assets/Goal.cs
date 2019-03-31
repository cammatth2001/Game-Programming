using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal : MonoBehaviour {

    public Text wonText;
    public int timeLeft = 10;
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
        if (Score.CurrentScore == 500)
        {
            wonText.text = "You Won!!";
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
                Restart.text = "The Game is restarting";
                yield return new WaitForSeconds(3);
                SceneManager.LoadScene(0);
                break;
            }
        }
    }
    void OnTriggerEnter2D ()
	{
		Score.CurrentScore += 100;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
	}
    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);

    }


}
