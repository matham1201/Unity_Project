using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    // Référence au texte affichant le score du joueur 1
    public Text scoreTextPlayer1;
    
    // Référence au texte affichant le score du joueur 2
    public Text scoreTextPlayer2;

    // Compteurs de buts pour chaque joueur
    private int goalsScoredPlayer1 = 0;
    private int goalsScoredPlayer2 = 0;

    // Appelé une fois au démarrage du jeu
    private void Start()
    {
        // Mettre à jour les textes pour afficher les scores initiaux
        UpdateScoreText();
    }

    // Méthode pour mettre à jour les textes affichant les scores
    private void UpdateScoreText()
    {
        // Mettre à jour le texte pour afficher les scores des deux joueurs
        scoreTextPlayer1.text = "Player 1 Score: " + goalsScoredPlayer1;
        scoreTextPlayer2.text = "Player 2 Score: " + goalsScoredPlayer2;
    }

    // Méthode appelée lorsque le joueur 1 marque un but
    public void IncrementScorePlayer1()
    {
        // Incrémenter le compteur de buts du joueur 1
        goalsScoredPlayer1++;

        // Mettre à jour le texte affichant le score du joueur 1
        UpdateScoreText();
    }

    // Méthode appelée lorsque le joueur 2 marque un but
    public void IncrementScorePlayer2()
    {
        // Incrémenter le compteur de buts du joueur 2
        goalsScoredPlayer2++;

        // Mettre à jour le texte affichant le score du joueur 2
        UpdateScoreText();
    }
}
