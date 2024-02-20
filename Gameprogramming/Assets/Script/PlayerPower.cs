using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    public GameObject goal;
    public Vector3 enlargedGoalScale = new Vector3(2f, 1f, 1f);
    public Vector3 originalGoalScale = new Vector3 (0f, 0, 1f);
    public float powerupDuration = 5f;
    private bool isGoalEnlarged = false;
    private float powerupTimer = 0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            EnlargeGoal();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            ShrinkGoal();
        }

        if (powerupTimer > 0)
        {
            powerupTimer -= Time.deltaTime;
            if (powerupTimer <= 0)
            {
                ResetPowerups();
            }
        }
    }
    void EnlargeGoal()
    {
        if (!isGoalEnlarged)
        {
            goal.transform.localScale = enlargedGoalScale;
            isGoalEnlarged = true;
            powerupTimer = powerupDuration;
        }
    }

    void ShrinkGoal()
    {
        if (isGoalEnlarged)
        {
            goal.transform.localScale = originalGoalScale;
            isGoalEnlarged = false;
            powerupTimer = powerupDuration;
        }
    }

    void ResetPowerups()
    {
        if (isGoalEnlarged)
        {
            goal.transform.localScale = originalGoalScale;
            isGoalEnlarged = false;
        }
    }
}