using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float maxForceMultiplier = 100f; 
    public float minForceMultiplier = 20f; 
    public float maxDistance = 5f; 
    public LayerMask ballLayer; 
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Key R pressed.");
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, maxDistance, ballLayer);
            if (hit.collider != null)
            {
                Debug.Log("Ball hit detected.");
                float distance = Mathf.Clamp(hit.distance, 0f, maxDistance);
                float forceMultiplier = Mathf.Lerp(minForceMultiplier, maxForceMultiplier, distance / maxDistance);
                
                Vector2 direction = (hit.point - (Vector2)transform.position).normalized;
                Debug.Log("Force multiplier: " + forceMultiplier);
                Debug.DrawRay(transform.position, direction * maxDistance, Color.green, 2f);
                rb.AddForce(direction * forceMultiplier, ForceMode2D.Impulse);
                Debug.Log("Force applied to ball.");
            }
            else
            {
                Debug.Log("No ball hit detected.");
            }
        }
    }
}
