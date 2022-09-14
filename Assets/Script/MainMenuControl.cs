using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene("Game");
    }
    public void credit_scene()
    {
        SceneManager.LoadScene("Credit_Scene");
    }
    public void backToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void gitHub(string link)
    {
        Application.OpenURL(link);
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("GoodBye");
    }
}
