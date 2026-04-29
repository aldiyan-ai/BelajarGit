using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void StartGame()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.Startgame();
        }
        else
        {
            SceneManager.LoadScene("Game");
        }
    }

    public void ResumeGame()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.ResumeGame();
        }
    }

    public void Restart()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.RestartToMenu();
        }
        else
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void QuitGame()
    {
        Debug.Log("Keluar Game...");
        Application.Quit();
    }
}