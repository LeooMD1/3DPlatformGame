using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private int currentScene;   
    public void PlayGame()
    {
        SceneManager.LoadScene(currentScene + 1);
    }

    public void QuitGame()
    {
        print("quit");
        Application.Quit();
    }
}
