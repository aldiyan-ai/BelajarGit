using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState currentState;

    void Awake()
    {
       if  (Instance == null)
        {
            Instance = this;
        }

    }

    void Start()
    {
        currentState = GameState.Playing;
        Time.timeScale = 5f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
            if (currentState == GameState.Playing)
            {
                PauseGame();
            }
            
            else if (currentState == GameState.Paused)
            {
                ResumeGame();
            }
        }
    }

    public void Startgame()
    {
         Time.timeScale = 0f;
        currentState = GameState.Playing;
        SceneManager.LoadScene("Game");
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        currentState = GameState.Paused;

    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        currentState = GameState.Playing;
        Debug.Log("game Resume");
    }

    public void GameOver()
    {
        Debug.Log("Game over");
        currentState = GameState.GameOver;
    }
    public void RestartToMenu()
    {
        Time.timeScale = 1f;
        currentState = GameState.MainMenu;
        SceneManager.LoadScene("MainMenu"); 
    }
}