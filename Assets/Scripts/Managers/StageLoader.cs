using UnityEngine;
using UnityEngine.SceneManagement;

public class StageLoader : MonoBehaviour
{
 
    public string[] SecondStages = { };
    public string[] ThirdStages = { };
    public string[] FourthStages = { };

    [SerializeField] private int nextStage = 1;

    public void LoadNextStage()
    {
        nextStage++;
        if (nextStage == 2)
        {
            int randomIndex = Random.Range(0, SecondStages.Length);
            SceneManager.LoadScene(SecondStages[randomIndex]);
        }
        else
        {
            if (nextStage == 3)
            {
                int randomIndex = Random.Range(0, ThirdStages.Length);
                SceneManager.LoadScene(ThirdStages[randomIndex]);
            }
            else
            {
                if (nextStage == 4)
                {
                    int randomIndex = Random.Range(0, FourthStages.Length);
                    SceneManager.LoadScene(FourthStages[randomIndex]);
                }

            }
        }
    }

}
