using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickPlayAgain : MonoBehaviour
{
    public void OnButtonClicked() 
    {
        SceneManager.LoadScene("MainScene");
    }
}
