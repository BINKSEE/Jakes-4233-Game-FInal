using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseCanvas;

    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0;
        pauseCanvas.SetActive(true);
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1;
        pauseCanvas.SetActive(false);
    }

    public void NewGame()
    {
        // Reset points
        PlayerPrefs.SetInt("Points", 0);
        Time.timeScale = 1;
        // Load current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}


