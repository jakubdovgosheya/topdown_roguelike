using UnityEngine;

public class PlayerCount : MonoBehaviour
{
    private int enemiesLive = 0;

    StageLoader stageLoader;

    public void CountEnemiesUp()
    {
        enemiesLive++;
        Debug.Log("Counted " + enemiesLive + " enemies!");
    }

    public void CountEnemiesDown()
    {
        enemiesLive--;
        Debug.Log(enemiesLive + " enemies left!");
        if (enemiesLive <= 0)
        {
            StageWon();
        }
    }

    private void StageWon()
    {
        Debug.Log("You won the stage!");
        UpgradeSpawner[] spawners = FindObjectsByType<UpgradeSpawner>(FindObjectsSortMode.None);

        foreach (var spawner in spawners)
        {
            spawner.SpawnUpgrade();
        }

        //stageLoader = GetComponent<StageLoader>();
        //stageLoader.LoadNextStage();
    }    
}
