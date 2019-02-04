using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]



public class Question
{
    public string question;
    public string answer;
    public string option1;
    public string option2;
    public string option3;
    public string option4;


    public void QuestionInventory(System.Xml.XmlNode questions)
    {
        string question = questions.Attributes["ID"].Value;
        //	answer = curQuestion.Attributes["Answer"].Value; 
        string option1 = questions.Attributes["OptionA"].Value;
        string option2 = questions.Attributes["OptionB"].Value;
        string option3 = questions.Attributes["OptionC"].Value;
        string option4 = questions.Attributes["OptionD"].Value;

    }
}

//Read XML into the files to create the questions and answers!