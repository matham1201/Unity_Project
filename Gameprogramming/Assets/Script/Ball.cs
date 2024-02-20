using UnityEngine;

public class Ball : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(transform.position.x, 2f, transform.position.z);
    }

    void FixedUpdate()
    {
        // Mouvement horizontal
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal, 0f);
        rb.velocity = movement * moveSpeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Action lorsque le ballon entre en collision avec la tête du joueur
            Debug.Log("Le ballon a touché la tête du joueur !");
        }
        else if (other.CompareTag("Ground"))
        {
            // Action lorsque le ballon entre en collision avec le sol
            Debug.Log("Le ballon a touché le sol !");
        }
    }
}

