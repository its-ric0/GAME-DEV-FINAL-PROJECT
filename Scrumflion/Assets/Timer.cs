using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    float elapsedtime;
    int minutes;
    int seconds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedtime += Time.deltaTime;
        minutes = Mathf.FloorToInt(elapsedtime/60);
        seconds = Mathf.FloorToInt(elapsedtime % 60);
        timerText.text = String.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
