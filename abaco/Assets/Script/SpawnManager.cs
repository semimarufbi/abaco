using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    GameObject redApple;
    [SerializeField]
    GameObject greenApple;
    [SerializeField]
    GameObject goldenApple;

    float timer, initialTime = 1.2f;
    int appleType;

    void Spawn() 
    { 
        if (timer <= 0 ) 
        {
            appleType = Random.Range(0, 100);
        }
        else if (appleType > 90) 
        { 
            
        }
    }
}
