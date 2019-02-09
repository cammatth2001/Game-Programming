using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
        List<Question> game = new List<Question>();

        TextAsset csvFile = Resources.Load<TextAsset>("Questions");

        string[] data = csvFile.text.Split(new char[] {'\n'});

        Debug.Log(data.Length);

         for (int i = 0; i < data.Length; i++)
          {
              string[] row = data[i].Split(new char[] { ',' });
              Question q = new Question();
                  q.question = row[0];
                  q.optionA = row[1];
                  q.optionB = row[2];
                  q.optionC = row[3];
                  q.optionD = row[4];
                  q.answer = row[5];

                  game.Add(q);

          }
          foreach (Question q in game)
          {
              Debug.Log(q.question);
          }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
