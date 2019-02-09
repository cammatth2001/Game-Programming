using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalCountDown : MonoBehaviour {
    int time, a;
    float x;
    public bool count;
    public string timeDisp;



    // Use this for initialization
    void Start()
    {
        time = 3;
        count = false;
    }

        // Update is called once per frame
        void Update() {
            if (count)
            {
                timeDisp = time.ToString();
                GameObject.Find("StartCounter").GetComponent<Text>().text = timeDisp;
                x += Time.deltaTime;
                a = (int)x;
                print(a);
                switch (a)
                {
                    case 0: GameObject.Find("StartCounter").GetComponent<Text>().text = "3"; break;
                    case 1: GameObject.Find("StartCounter").GetComponent<Text>().text = "2"; break;
                    case 2: GameObject.Find("StartCounter").GetComponent<Text>().text = "1"; break;
                    case 3:
                        GameObject.Find("StartCounter").GetComponent<Text>().enabled = false;
                        count = false; break;

                }
            }
        }
 }