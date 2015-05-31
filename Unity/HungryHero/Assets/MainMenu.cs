using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Application.LoadLevel("Game");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PlayAgain()
    {
        Application.LoadLevel("Game");
    }
    public void BackToMainMenu()
    {
        Application.LoadLevel("StartGame");
    }
}
