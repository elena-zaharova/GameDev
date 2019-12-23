using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
   public void LwlOnePressed()
    {
        SceneManager.LoadScene("lvl1");
    }

    public void LwlTwoPressed()
    {
        SceneManager.LoadScene("lvl2");
    }

    public void LwlThreePressed()
    {
        SceneManager.LoadScene("lvl3");
    }

    public void LwlFourPressed()
    {
        SceneManager.LoadScene("lvl1");
    }

    public void LwlFivePressed()
    {
        SceneManager.LoadScene("lvl2");
    }

    public void MenuPressed()
    {
        SceneManager.LoadScene("menu");
    }



}
