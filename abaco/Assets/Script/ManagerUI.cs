using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI scoreText, recordText, lifeText;
    [SerializeField]
    GameObject gameOverPanel;
#region
    static public UIManager instance;
   void Awake()
    {
        instance = this;
    }
    #endregion
    public void UpdateScoreText() 
    {
        scoreText.text = GameManager.instance.Score.ToString();
    }
    void UpdateLifeText()
    {
        scoreText.text = GameManager.instance.Lifes.ToString();
    }
    public void GameOver()
    {
        recordText.text = "Recorde: " + PlayerPrefs.GetInt("Record");
        gameOverPanel.SetActive(true);
    }
    public void Reload()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }


}
