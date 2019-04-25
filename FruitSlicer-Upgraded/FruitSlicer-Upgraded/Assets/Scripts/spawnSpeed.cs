using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSpeed : MonoBehaviour
{
    public void GetSpeed(float speed)
    {
     
        FruitSpawner.maxDelay = speed;

        Debug.Log(FruitSpawner.maxDelay);
    }
}
