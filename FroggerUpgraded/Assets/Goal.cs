using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal : MonoBehaviour {

    public Text wonText;

    void OnTriggerEnter2D ()
	{
		//Debug.Log("YOU WON!");
		Score.CurrentScore += 100;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        if(Score.CurrentScore == 500)
        {
            wonText.text = "You Won!!";
            SceneManager.LoadScene(0);
        }
	}

}
