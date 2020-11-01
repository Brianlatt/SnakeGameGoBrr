using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageButton : MonoBehaviour
{
    // Loads the scene listed From play button
    public void PlayButton(string newGame)
    {
        SceneManager.LoadScene(newGame);
        Time.timeScale = 1f;
    }

    // Exit Button
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }
}
