using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{    

    [SerializeField]  GameObject redApple;
    [SerializeField]  GameObject greenApple;
    [SerializeField]  GameObject goldenApple;

     float timer;
     float initialTime = 1.2f;

     int appleType;

    void Start()
    {
        timer = initialTime;
    }

    void Update()
    {
        Spawn();
    }

    private void Spawn()
    {
        if (timer <= 0)
        {
            appleType = Random.Range(0, 101);

            if (appleType > 90)
            {
                Instantiate(goldenApple, new Vector3(
                    Random.Range(-GameManager.instance.ScreenBounds.x, GameManager.instance.ScreenBounds.x),
                    GameManager.instance.ScreenBounds.y,
                    0), Quaternion.identity);
            }
            else if (appleType > 60)
            {
                Instantiate(greenApple, new Vector3(
                    Random.Range(-GameManager.instance.ScreenBounds.x, GameManager.instance.ScreenBounds.x),
                    GameManager.instance.ScreenBounds.y,
                    0), Quaternion.identity);
            }
            else
            {
                Instantiate(redApple, new Vector3(
                    Random.Range(-GameManager.instance.ScreenBounds.x, GameManager.instance.ScreenBounds.x),
                    GameManager.instance.ScreenBounds.y,
                    0), Quaternion.identity);
            }

            if (initialTime > 0.8f)
            {
                initialTime -= 0.05f;
            }

            timer = initialTime;
        }
        else
        {
            timer -= Time.deltaTime;

        else
        {
            timer -= Time.deltaTime;
        }
    }
}




        
