using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    void Update()
    {
        scoreText.text = ("Score: ") + score.ToString();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score++;
        }
        
    }
}
