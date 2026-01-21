using UnityEngine;

public class UpgradeSpawner : MonoBehaviour
{
    [SerializeField] GameObject upgradeType;
    Transform spawnLocation;

    private void Awake()
    {
        spawnLocation = gameObject.transform;
    }
    public void SpawnUpgrade()
    {
        Instantiate(upgradeType, spawnLocation.position, Quaternion.identity);
    }

}
