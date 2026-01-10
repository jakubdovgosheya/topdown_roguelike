using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int startingHealth = 10;
    private int health;

    private void Awake()
    {
        health = startingHealth;
    }

    public void TakeDamage (int damage)
    {
        if (health <= 0)
        {
            return;
        }

        {
            health -= damage;
            Debug.Log("Player has " + health + " HP left");

            if (health <= 0)
            {
                Die();
            }
        }
    }

    private void Die()
    {
        Debug.Log("Player died");
    }
}
