using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  static public GameManager instance;
    Vector2 screenBounds;
    int score;
    int lifes = 3;

    public Vector2 ScreenBounds { get => screenBounds;  }
    public int Score { get => score; set => score = value; }
    public int Lifes { get => lifes; }

    private void Awake()
    {
         instance = this;

        screenBounds = new Vector3(-1, 1, 0) + Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }
    public void LoseLife() 
    {
        lifes -= 1;
        ManagerUI.instance.UpdateLifeText();

        if (lifes = 0)
        {
            if (score > PlayerPrefs.GetInt("Record", Score))
            { 
                
            }
           
            Time.timeScale = 0;
           ManagerUI.instance.GameOver();
        }
    }
}
