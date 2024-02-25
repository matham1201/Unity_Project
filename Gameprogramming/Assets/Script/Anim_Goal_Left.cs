using UnityEngine;

public class Anim_Goal_Left : MonoBehaviour
{
    // Compteur de buts
    public int goalsScored = 0;

    // Méthode appelée lorsque le collider est touché
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            Debug.Log("Goal Left");

            // Incrémenter le compteur de buts
            goalsScored++;

            // Afficher le nombre de buts marqués dans la console
            Debug.Log("Goals Scored: " + goalsScored);

            // Réinitialiser la position du ballon
            Ball ballScript = other.GetComponent<Ball>();
            ballScript.ResetBallPosition();

            // Arrêter la vitesse du ballon
            Rigidbody2D ballRigidbody = other.GetComponent<Rigidbody2D>();
            ballRigidbody.velocity = Vector2.zero;
            ballRigidbody.angularVelocity = 0f;
            ballRigidbody.Sleep(); 
        }
    }
}
