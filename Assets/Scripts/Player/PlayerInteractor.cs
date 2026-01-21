using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteractor : MonoBehaviour
{
    public void OnInteract()
    {
        var upgrades =
           FindObjectsByType<UpgradeTriggerEnter>(FindObjectsSortMode.None);

        foreach (var upgrade in upgrades)
        {
            upgrade.TriggerInteracted();
        }
    }

}
