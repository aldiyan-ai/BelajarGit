using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void StartGame()
    {
        GameManager.Instance.currentState = GameState.Playing;
        Time.timeScale = 2f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        GameManager.Instance.RestartToMenu();
        Time.timeScale = 1f;
    }

    public void ResumeGame()
    {
        GameManager.Instance.ResumeGame();
    }
}