using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuestionLoader : MonoBehaviour
{

    [SerializeField]
    public Text question;
    [SerializeField]
    public Text optionA;
    [SerializeField]
    public Text optionB;
    [SerializeField]
    public Text optionC;
    [SerializeField]
    public Text answer;
    [SerializeField]
    private float timeBetweenQuestions = 1F;
    [SerializeField]
    public Text scoreText;
    [SerializeField]
    public Text timeCounter;
    public Question[] questions;
    List<Question> game = new List<Question>();
    [SerializeField]
    float timeLeft = 30.0f;

    private Question currentQuestion;
    public static List<Question> unansweredQuestions;
   
    void Start()
    {
        TextAsset csvFile = Resources.Load<TextAsset>("Questions");

        string[] data = csvFile.text.Split(new char[] { '\n' });

        Debug.Log(data.Length);

        for (int i = 0; i < data.Length; i++)
        {
            string[] row = data[i].Split(new char[] { ',' });
            Question q = new Question();
            q.question = row[0];
            q.optionA = row[1];
            q.optionB = row[2];
            q.optionC = row[3];
            q.answer = row[4];
           // int.TryParse(row[5], out q.scoreText);

            game.Add(q);
        }
        

     
        scoreText.text = "0";

        SetCurrentQuestion();
        UpdateTime();

    }
    void SetCurrentQuestion()
    {
        foreach (Question q in game)
        {
            Debug.Log(q.question);
            question.text = q.question;
            optionA.text = q.optionA;
            optionB.text = q.optionB;
            optionC.text = q.optionC;
            answer.text = q.answer;
        }
    }
    void UpdateTime()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Debug.Log("Times UP");
        }
        timeCounter.text = timeLeft.ToString();
    }
   
    IEnumerator TransitionToNextQuestion()
    {
        yield return new WaitForSeconds(timeBetweenQuestions);

       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void UserSelectA()
    {
        if (optionA.text == answer.text)
        {
            Debug.Log("Correct!");
        }
        else
        {
            Debug.Log("Wrong!");
            int score = 0;
            score = score - 10;
            scoreText.text = "Score " + score;
            
        }
        
        StartCoroutine(TransitionToNextQuestion());
    }

    public void UserSelectB()
    {
        if (optionB.text == answer.text)
        {
            Debug.Log("Correct!");
        }
        else
        {
            Debug.Log("Wrong!");
            int score = 0;
            score = score - 10;
            scoreText.text = "Score " + score;
            
        }
       
        StartCoroutine(TransitionToNextQuestion());
    }
    public void UserSelectD()
    {
        if (answer.text == answer.text)
        {
            
            Debug.Log("Correct!");
            int score = 0;
            score = score + 10;
            scoreText.text = "Score " + score;
           
        }
        else
        {
            Debug.Log("Wrong!");
        }
       
        StartCoroutine(TransitionToNextQuestion());
    }
    public void UserSelectC()
    {
        if (optionC.text == answer.text)
        {
            Debug.Log("Correct!");

        }
        else
        {
            Debug.Log("Wrong!");
            int score = 0;
            score = score - 10;
            scoreText.text = "Score " + score;
           
        }

        
        StartCoroutine(TransitionToNextQuestion());

    }
    void Update()
    {
       
        UpdateTime();
    }



}
