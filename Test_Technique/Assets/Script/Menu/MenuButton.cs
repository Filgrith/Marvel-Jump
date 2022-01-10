using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenu;


    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                Resume();
            else
                Pause();
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void MainMenu() 
    {
        SceneManager.LoadScene("MainMenu");
        Resume();
    }

    public void Retry() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Resume();
    }

    public void ExitGame() => Application.Quit();

    public void Level2()
    {
        SceneManager.LoadScene("Level_2");
        Resume();
    }
    public void Level1()
    {
        SceneManager.LoadScene("Level_1");
        Resume();
    }

}
