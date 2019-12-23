using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextMenu : MonoBehaviour
{
    string index = TimeManager.index;

    void Start()
    {
        string name = SceneManager.GetActiveScene().name;
        Debug.Log(index);
    }
    public void MenuPressed()
    {
        SceneManager.LoadScene("menu", LoadSceneMode.Single);
    }

    public void RetryPressed()
    {
        if(index == "lvl1")
        {
            SceneManager.LoadScene("lvl1", LoadSceneMode.Single);
        }
        else
        {
            if (index == "lvl2")
            {
                SceneManager.LoadScene("lvl2", LoadSceneMode.Single);
            }
            else
            {
                if(index == "lvl3")
                {
                    SceneManager.LoadScene("lvl3", LoadSceneMode.Single);
                }
            }
        }
    }
    public void NextLevel()
    {
 
        
        if (index == "lvl1")
        {
            SceneManager.LoadScene("lvl2", LoadSceneMode.Single);
        }
        else
        {
            if (index == "lvl2")
            {
                SceneManager.LoadScene("lvl3", LoadSceneMode.Single);
            }
            else
            {
                if (index == "lvl3")
                {
                    SceneManager.LoadScene("lvl1", LoadSceneMode.Single);
                }
            }
        }
    }
}
