using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;

public class UpgradeTriggerEnter : MonoBehaviour
{
    private bool playerInRange = false; 
    [SerializeField] private UnityEvent upgradeEffect;

    private void OnTriggerEnter2D (Collider2D other)
    {
        playerInRange = true;
        Debug.Log("Player can pick an upgrade!");
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        playerInRange = false;
        Debug.Log("Player can't pick an upgrade anymore");
    }


    public void TriggerInteracted()
    {
        if (playerInRange)
        {
            upgradeEffect.Invoke();
            Debug.Log("Upgrade effect is being triggered");
        }
    }
}
