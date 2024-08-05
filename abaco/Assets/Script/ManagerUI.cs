using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI scoreText, recordText, lifeText;
    [SerializeField]
    GameObject gameOverPanel;
#region
    static public UIManager instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion

}
