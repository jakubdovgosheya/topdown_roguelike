using UnityEngine;
using UnityEngine.SceneManagement;

public class SpeedUpgrade : MonoBehaviour
{
    SetStats statSetter;
    StageLoader stageLoader;
    [SerializeField] private int speedIncreaseValue = 1;

    public void IncreaseSpeed()
    {
        statSetter = FindFirstObjectByType<SetStats>();
        statSetter.IncreaseSpeed(speedIncreaseValue);
        stageLoader = FindAnyObjectByType<StageLoader>();
        stageLoader.LoadNextStage();
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }

}
