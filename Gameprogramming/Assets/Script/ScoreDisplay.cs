using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    // Référence au texte affichant le score
    private Text scoreText;

    // Compteur de buts
    private int goalsScored = 0;

    // Appelé une fois au démarrage du jeu
    private void Start()
    {
        // Trouver le composant Text
        scoreText = GetComponent<Text>();

        // Mettre à jour le texte pour afficher le score initial
        UpdateScoreText();
    }

    // Méthode pour mettre à jour le texte affichant le score
    private void UpdateScoreText()
    {
        // Mettre à jour le texte avec le nombre de buts marqués
        scoreText.text = "Goals Scored: " + goalsScored;
    }

    // Méthode appelée lorsque le collider est touché
    public void IncrementScore()
    {
        // Incrémenter le compteur de buts
        goalsScored++;

        // Mettre à jour le texte affichant le score
        UpdateScoreText();
    }
}
