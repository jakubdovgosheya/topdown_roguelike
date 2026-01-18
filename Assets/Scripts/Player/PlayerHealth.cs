using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int startingHealth = 10;
    private int health;
    public string deathMenu;
    SetStats statSetter;

    private void Awake()
    {
        statSetter = FindFirstObjectByType<SetStats>();
        statSetter.SetPlayerMaxHealth();
        health = startingHealth;
    }

    public void SetMaxHealth(int maxHealth)
    {
        startingHealth = maxHealth;
        Debug.Log("Max health set to " + startingHealth);
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
        SceneManager.LoadScene(deathMenu);
    }
}
