using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshPro scoreText;
    private int score = 0;
    
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        updateScoreText();
    }

    
    public void AddScore(int points)
    {
        score += points;
        updateScoreText();
    }
    void updateScoreText()
    {

    }
}
