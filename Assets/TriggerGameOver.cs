using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerGameOver : MonoBehaviour
{
    private string sceneName = "GameOver"; 

    void OnTriggerEnter2D(Collider2D other)  
    {
        if (other.gameObject.layer == 3) 
        {
            // Switch to GameOver Scene
            SceneManager.LoadScene(sceneName);
        }
    }
}
