using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GuitGame()
    {
        Debug.Log("NOOOOOOOOOOOO WHY DID U QUITTT THIS GAME IS PERFECT!!!!! AHHHHHHHHHH");
        Application.Quit();
    }

}
