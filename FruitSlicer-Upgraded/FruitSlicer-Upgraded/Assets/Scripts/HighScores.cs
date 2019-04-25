using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class HighScores : MonoBehaviour
{
    public Text HighScoresText;
    public int topScores = 10;


   
    void Start()
    {
        WriteScores();
    }

    void WriteScores()
    {
        string path = "Assets/scores.txt"; 
        string[] lines; 
        string playerName; 
        double score; 
        bool scoreWritten = false;

        string[] playerScores = File.ReadAllLines(path); 
        Debug.Log(playerScores);



        StreamWriter writer = new StreamWriter(path); 

        foreach (string playerScore in playerScores)
        {
            
            lines = playerScore.Split(','); 
            playerName = lines[0]; 
            score = Convert.ToInt32(lines[1]); 
            if (score < Score.CurrentScore && scoreWritten == false)
            {
                writer.Write(PlayerName.playerName + "," + Score.CurrentScore + "\n"); 
                HighScoresText.text += PlayerName.playerName + " : " + Score.CurrentScore.ToString() + "\n";
                scoreWritten = true;
                Debug.Log(PlayerName.playerName + " : " + score.ToString() + "\n");
            }
            writer.Write(playerScore + "\n"); 
            HighScoresText.text += playerName + " : " + score.ToString() + "\n"; 
            Debug.Log(playerName + " : " + score.ToString() + "\n");
        }

        writer.Close(); 



        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("scores");

    }
}