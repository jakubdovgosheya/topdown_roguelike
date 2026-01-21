using UnityEngine;

public class SetStats : MonoBehaviour
{

    PlayerHealth playerHealth;
    PlayerMovement playerMovement;

    [SerializeField] public int maxPlayerHealth = 10;
    [SerializeField] public float playerSpeed = 8;

    public void SetPlayerMaxHealth()
    {
        Debug.Log("Setting player Health!");
        playerHealth = FindFirstObjectByType<PlayerHealth>();
        playerHealth.SetMaxHealth(maxPlayerHealth);
    }

    public void SetPlayerSpeed()
    {
        Debug.Log("Setting player Speed!");
        playerMovement = FindFirstObjectByType<PlayerMovement>();
        playerMovement.SetSpeed(playerSpeed);
    }

    public void IncreaseMaxHealth(int maxHealthIncrease)
    {
        maxPlayerHealth = maxPlayerHealth + maxHealthIncrease;
    }


    public void IncreaseSpeed(int speedIncrease)
    {
        playerSpeed = playerSpeed + speedIncrease;
    }
}
