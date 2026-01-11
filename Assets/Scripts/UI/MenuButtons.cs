using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public string[] startingScenes = { };

    public void NewRun()
    {
        int randomIndex = Random.Range(0, startingScenes.Length);
        SceneManager.LoadScene(startingScenes[randomIndex]);
    }
    public void QuitGame()
    {
        Application.Quit();

    }

}
