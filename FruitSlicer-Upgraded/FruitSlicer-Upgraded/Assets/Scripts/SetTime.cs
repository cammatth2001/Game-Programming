using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTime : MonoBehaviour
{
    
    public void GetInput(string time)
    {
        int.TryParse(time, out Goal.timeLeft);
        Debug.Log(Goal.timeLeft);
    }
}
