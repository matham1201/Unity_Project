using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreText; 

    private int ScoreNumber;

    void Start()
    {
       ScoreNumber = 0;
       scoreText.text = "Score: " + ScoreNumber;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            ScoreNumber++;
            scoreText.text = "Score: " + ScoreNumber;
        }
    }
                
    
}
