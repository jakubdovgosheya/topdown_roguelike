using UnityEngine;

public class PlayerCount : MonoBehaviour
{
    private int enemiesLive = 0;

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
    }    
}
