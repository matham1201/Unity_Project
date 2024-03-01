using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timeElapsed = 0f;
    private bool gameRunning = true;

    void Update()
    {
        if (gameRunning)
        {
            timeElapsed += Time.deltaTime;

            UpdateTimerText();

            if (timeElapsed >= 180f)
            {
                gameRunning = false;
                Debug.Log("La partie est terminée.");

#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#else
                    Application.Quit(); 
#endif
            }
        }
    }

    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(timeElapsed / 60f);
        int seconds = Mathf.FloorToInt(timeElapsed % 60f);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
