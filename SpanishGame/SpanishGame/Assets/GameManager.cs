using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{/*

    public QuestionLoader[] questions;

    private static List<QuestionLoader> unansweredQuestions;
    private QuestionLoader currentQuestion;
    [SerializeField]
    private Text factText;
    [SerializeField]
    private Text optionA;
    [SerializeField]
    private Text optionB;
    [SerializeField]
    private Text optionC;
    [SerializeField]
    private Text optionD;


    [SerializeField]
    private float timeBetweenQuestions = 1F;

    void Start()
    {

        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<QuestionLoader>();
        }

        SetCurrentQuestion();
    }
   /* void SetCurrentQuestion()
    {
        factText.text = currentQuestion.question;
        optionA.text = currentQuestion.optionA;
        optionB.text = currentQuestion.optionB;
        optionC.text = currentQuestion.optionC;
        optionD.text = currentQuestion.optionD;
        

        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];
    }

    IEnumerator TransitionToNextQuestion()
    {
        unansweredQuestions.Remove(currentQuestion);
        yield return new WaitForSeconds(timeBetweenQuestions);
    }
*/
    
}