using UnityEngine;
using UnityEngine.SceneManagement;

public class Canvas : MonoBehaviour
{
    public string levelToLoad;

    public void StartGameButton()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void QuitGameButton()
    {
        Application.Quit();
    }
}
