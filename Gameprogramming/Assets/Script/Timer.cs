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
            // Mettre à jour le temps écoulé
            timeElapsed += Time.deltaTime;

            // Mettre à jour le texte du timer
            UpdateTimerText();

            // Vérifier si une minute s'est écoulée
            if (timeElapsed >= 60f)
            {
                // Arrêter le jeu
                gameRunning = false;
                Debug.Log("Le jeu est terminé car une minute est écoulée.");

                // Vérifier si le jeu est en mode éditeur
                #if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
                #else
                    Application.Quit(); // Arrêter l'application en mode standalone
                #endif
            }
        }
    }

    void UpdateTimerText()
    {
        // Convertir le temps écoulé en minutes et secondes
        int minutes = Mathf.FloorToInt(timeElapsed / 60f);
        int seconds = Mathf.FloorToInt(timeElapsed % 60f);

        // Mettre à jour le texte avec le temps écoulé
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
