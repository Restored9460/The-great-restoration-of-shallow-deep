using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame ()
    {
        SceneManager.LoadScene("Woods - Final");
        

    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
