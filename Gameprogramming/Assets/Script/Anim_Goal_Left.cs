using UnityEngine;

public class Anim_Goal_Left : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            Debug.Log("Goal Left");

            Ball ballScript = other.GetComponent<Ball>();
            ballScript.ResetBallPosition();

            Rigidbody2D ballRigidbody = other.GetComponent<Rigidbody2D>();
            ballRigidbody.velocity = Vector2.zero;
            ballRigidbody.angularVelocity = 0f;
            ballRigidbody.Sleep(); 
        }
    }
}
