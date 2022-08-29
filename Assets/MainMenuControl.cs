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
    public void Author()
    {
        Debug.Log("Created By Rizki Herdian");
    }
}
