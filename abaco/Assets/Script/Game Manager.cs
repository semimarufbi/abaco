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


    }
}
