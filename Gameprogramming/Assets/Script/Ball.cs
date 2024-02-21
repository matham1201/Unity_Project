using UnityEngine;

public class Ball : MonoBehaviour
{
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = Vector3.zero; 
    }

    public void ResetBallPosition()
    {
        transform.position = initialPosition;
    }
}
