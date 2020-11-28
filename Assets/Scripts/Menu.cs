using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public UnityEngine.UI.RawImage CreditsPanel;

    public void LoadLevel()
    {
        SceneManager.LoadScene("Level");
    }

    public void ReloadLevel()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void ShowCredits()
    {
        if (SceneManager.GetActiveScene().name == "Menu")
            CreditsPanel.gameObject.SetActive(true);
    }

    public void BackToMenu()
    {
        if (SceneManager.GetActiveScene().name == "Menu")
            CreditsPanel.gameObject.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}