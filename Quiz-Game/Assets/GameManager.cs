using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;
using System.Xml;

public class GameManager : MonoBehaviour {

	public Question[] questions;

	//Read Question True or False into the Questions List

	
	private static List<Question> unansweredQuestions;
	private Question currentQuestion;
	[SerializeField]
	private Text questionText;

	[SerializeField]
	private float timeBetweenQuestions = 1F;

	// Use this for initialization
	void Start () 
	{
		if(unansweredQuestions == null || unansweredQuestions.Count == 0)
		{
			unansweredQuestions = questions.ToList<Question>();
		}	
		setCurrentQuestion();
		//Debug.Log(currentQuestion.fact + " is " + currentQuestion.isTrue);
	}	
	void setCurrentQuestion()
	{
		int randomQuestionIndex = Random.Range (0, unansweredQuestions.Count);
		currentQuestion = unansweredQuestions[randomQuestionIndex];
		questionText.text = currentQuestion.question;
	}
	
	IEnumerator TransitionToNextQuestion()
	{
		unansweredQuestions.Remove(currentQuestion);
		yield return new WaitForSeconds(timeBetweenQuestions);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void UserSelectTrue()
	{
		if(currentQuestion.option1 == currentQuestion.answer)
		{
            Debug.Log("Correct!");
		}else{
            Debug.Log("Wrong!");
		}
		StartCoroutine(TransitionToNextQuestion());
	}

	public void UserSelectFalse()
	{
		if(currentQuestion.option2 == currentQuestion.answer)
		{
            Debug.Log("Correct!");
		}else{
            Debug.Log("Wrong!");
		}
		StartCoroutine(TransitionToNextQuestion());
	}
}
