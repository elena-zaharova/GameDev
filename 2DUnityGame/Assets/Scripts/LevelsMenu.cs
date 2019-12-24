using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
    public GameObject st1l1, st2l1, st3l1, st1l2, st2l2, st3l2, st1l3, st2l3, st3l3;

    string key1 = "lvl1";
    string key2 = "lvl2";
    string key3 = "lvl3";

    void Start()
    {
        if(!PlayerPrefs.HasKey(key1) && !PlayerPrefs.HasKey(key2) && !PlayerPrefs.HasKey(key3))
        {
            PlayerPrefs.SetInt(key1, 0);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt(key2, 0);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt(key3, 0);
            PlayerPrefs.Save();
        }
        else
        {
            if (!PlayerPrefs.HasKey(key2) && !PlayerPrefs.HasKey(key3))
            {
                PlayerPrefs.SetInt(key2, 0);
                PlayerPrefs.Save();
                PlayerPrefs.SetInt(key3, 0);
                PlayerPrefs.Save();
            }
            else
            {
                if (!PlayerPrefs.HasKey(key3))
                {
                    PlayerPrefs.SetInt(key3, 0);
                    PlayerPrefs.Save();
                }
            }
        }
        if(PlayerPrefs.HasKey(key1))
        {
            int star1 = PlayerPrefs.GetInt(key1);
            if(star1 == 0)
            {
                Destroy(st1l1);
                Destroy(st2l1);
                Destroy(st3l1);
            }
            else
            {
                if (star1 == 1)
                {
                    Destroy(st2l1);
                    Destroy(st3l1);
                }
                else
                {
                    if (star1 == 2)
                    {
                        Destroy(st3l1);
                    }
                }
            }
        }
        if (PlayerPrefs.HasKey(key2))
        {
            int star2 = PlayerPrefs.GetInt(key2);
            if (star2 == 0)
            {
                Destroy(st1l2);
                Destroy(st2l2);
                Destroy(st3l2);
            }
            else
            {
                if (star2 == 1)
                {
                    Destroy(st2l2);
                    Destroy(st3l2);
                }
                else
                {
                    if (star2 == 2)
                    {
                        Destroy(st3l2);
                    }
                }
            }
        }
        if (PlayerPrefs.HasKey(key3))
        {
            int star3 = PlayerPrefs.GetInt(key3);
            if (star3 == 0)
            {
                Destroy(st1l3);
                Destroy(st2l3);
                Destroy(st3l3);
            }
            else
            {
                if (star3 == 1)
                {
                    Destroy(st2l3);
                    Destroy(st3l3);
                }
                else
                {
                    if (star3 == 2)
                    {
                        Destroy(st3l3);
                    }
                }
            }
        }
    }

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
