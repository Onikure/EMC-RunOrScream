using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Method to be called when the 'Play' button is clicked
    public void PlayGame()
    {
        SceneManager.LoadScene("GAME");
    }

    // Method to be called when the 'Exit' button is clicked
    public void QuitGame()
    {
        // Quit the application
        Application.Quit();

        // The following line should only be compiled in the Unity Editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
