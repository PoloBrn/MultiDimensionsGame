using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereSceneManager : MonoBehaviour
{ 
    public string levelToLoad;

    private void OnCollisionEnter(Collision collision) // le type de la variable est Collision
    {
        if (collision.gameObject.tag == "Player") 
        {
            Debug.Log("Collision detected with player!");
            SceneManager.LoadScene(levelToLoad);
        }
    }
}