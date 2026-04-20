using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject instructionsPanel;

    void Start()
    {
        // Make sure it's hidden at start
        instructionsPanel.SetActive(false);
    }

    public void LoadScene(string MainLobby)
    {
        SceneManager.LoadScene("MainLobby");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    // Called by "Instructions" button
    public void ShowInstructions()
    {
        instructionsPanel.SetActive(true);
    }

    // Called by "Close" button inside panel
    public void HideInstructions()
    {
        instructionsPanel.SetActive(false);
    }
}