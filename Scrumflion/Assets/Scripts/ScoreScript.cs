using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public TextMeshPro scoreText;
    int scoreNum = 0;

    public void Start()
    {
        scoreText.text = scoreNum.ToString();
    }

    public void AddPoint()
    {
        scoreNum += 100;
    }
}
