using UnityEngine;
using UnityEngine.SceneManagement;

public class Canvas : MonoBehaviour
{
    private string tutorial = "Tutorial";
    private string credits = "Credits";
    public GameObject settings;

    void Start()
    {
        //Fait apparaitre la souris
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void StartGameButton()
    {
        SceneManager.LoadScene(tutorial);
    }

    public void SettingsButton()
    {
        settings.SetActive(true);
    }

    public void LevelChooseButton()
    {
        SceneManager.LoadScene("LevelSelector");
    }

    public void CreditGameButton()
    {
        SceneManager.LoadScene(credits);
    }

    public void QuitGameButton()
    {
        Application.Quit();
    }
}
