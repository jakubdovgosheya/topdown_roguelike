using UnityEngine;

public class MaxHPUpgrade : MonoBehaviour
{
    SetStats statSetter;
    StageLoader stageLoader;
    [SerializeField] private int maxHealthIncreaseValue = 10;

    public void IncreaseMaxHP()
    {
        statSetter = FindFirstObjectByType<SetStats>();
        statSetter.IncreaseMaxHealth(maxHealthIncreaseValue);
        stageLoader = FindAnyObjectByType<StageLoader>();
        stageLoader.LoadNextStage();
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
