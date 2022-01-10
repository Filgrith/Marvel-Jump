using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    void OnGUI() 
    {
        if(GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 50), "Play"))
            SceneManager.LoadScene("Level_1");

        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 50, 200, 50), "Option"))
        { }
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 150, 200, 50), "Score"))
        { }
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 250, 200, 50), "Quit the game"))
            Application.Quit();

    }
}
