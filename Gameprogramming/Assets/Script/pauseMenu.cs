using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;

    private bool isPaused = false;
    
     public void RetourMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    void Update()
    { 
        Time.timeScale = 1f;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    void Pause()
    {
        if (!isPaused)
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            isPaused = true;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
