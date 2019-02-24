using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public bool gameOver;
    private bool restart;

    // Use this for initialization
    void Start ()
    {
        gameOver = false;
        restart = false;

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);
            }
        } 
        if (gameOver)
        {
            restart = true;
        }
    }
    }
    
