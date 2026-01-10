using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
    
    [SerializeField] private int damage = 2;
    [SerializeField] private float attackCooldown = 2.0f;

    [SerializeField] private LayerMask playerLayer;

    private bool playerInRange = false;

    private float _lastAttackTime;

    private Coroutine damageCoroutine;



    private void OnTriggerEnter2D(Collider2D other)
    {

        if (((1 << other.gameObject.layer) & playerLayer) != 0)
        {
            Debug.Log("Player entered range!");
            playerInRange = true;
            damageCoroutine = StartCoroutine(DamagePlayer(other));
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (((1 << other.gameObject.layer) & playerLayer) != 0)
        {
            Debug.Log("Player left range!");
            playerInRange = false;
            StopCoroutine(damageCoroutine);
        }
    }


    IEnumerator DamagePlayer(Collider2D player)
    {
        while (playerInRange)
        {
            // tu wo³asz metodê gracza
            player.GetComponent<PlayerHealth>().TakeDamage(damage);

            yield return new WaitForSeconds(attackCooldown);
        }
    }
}

