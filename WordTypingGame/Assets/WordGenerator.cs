using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {

   private static TextAsset csvFile = Resources.Load<TextAsset>("Words");

   private static string[] wordList = csvFile.text.Split(new char[] { ',' });
                                    
	public static string GetRandomWord ()
	{
		int randomIndex = Random.Range(0, wordList.Length);
		string randomWord = wordList[randomIndex];

		return randomWord;
	}

}
