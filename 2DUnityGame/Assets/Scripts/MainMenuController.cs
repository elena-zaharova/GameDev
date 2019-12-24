using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    

    void Start()
    {
        
    }
    public void PlayPressed()
    {
        SceneManager.LoadScene("lvl1");
    }

    public void LevelsPressed()
    {
        SceneManager.LoadScene("levels");
    }

    public void HelpPressed()
    {
        SceneManager.LoadScene("help");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }

}
