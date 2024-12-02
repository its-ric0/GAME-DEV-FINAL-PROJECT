using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class coin : MonoBehaviour
{
    //[SerializeField] private TextMeshPro scoreText; // Reference to the UI Text for score
    

    void Start()
    {
        // Initialize the score text at start
        UpdateScoreText();
    }

    // Detect when the player collides with a coin
    void OnTriggerEnter(Collider other)
    {
        
    }

   
    void UpdateScoreText()
    {
        //scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
