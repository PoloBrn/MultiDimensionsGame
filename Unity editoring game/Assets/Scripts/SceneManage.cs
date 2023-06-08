using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{ 

    public string levelToLoad;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }

}
