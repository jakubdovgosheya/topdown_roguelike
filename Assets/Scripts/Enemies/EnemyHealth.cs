using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int startingHealth = 10;
    private int health;
    PlayerCount playerCount;


    private void Awake()
    {
        playerCount = FindFirstObjectByType<PlayerCount>();
        playerCount.CountEnemiesUp();
        health = startingHealth;

    }


    public void TakeDamage(int damage)
    {
        if (health <= 0)
        {
            return;
        }

        {
            health -= damage;
            Debug.Log("Enemy has " + health + " HP left");

            if (health <= 0)
            {
                Die();
            }
        }
    }

    private void Die()
    {
        playerCount.CountEnemiesDown();
        Destroy(gameObject);
    }
}
