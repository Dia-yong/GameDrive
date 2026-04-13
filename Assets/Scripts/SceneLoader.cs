using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadMainGameplay()
    {
        SceneManager.LoadScene("MainGameplay");
    }

    public void QuitGame()
    {
        Debug.Log("Game is quitting...");

        Application.Quit();
    }
}