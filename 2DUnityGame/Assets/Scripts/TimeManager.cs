using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public float startingTime;
    public GameObject mainBlock;

    private Text theText;
    private Vector3 pos;
    public static string index;

    // Start is called before the first frame update
    void Start()
    {
        theText = GetComponent<Text>();
        pos = new Vector3(0f, 1017f, 0f);
        index = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        startingTime -= Time.deltaTime;
        string key1 = "lvl1";
        string key2 = "lvl2";
        string key3 = "lvl3";

        if( Mathf.Round(startingTime) == 0 )
        {
            theText.text = "" + Mathf.Round(startingTime);
            if(index == "lvl1")
            {
                PlayerPrefs.SetInt(key1, 0);
                PlayerPrefs.Save();
            }
            else
            {
                if(index == "lvl2")
                {
                    PlayerPrefs.SetInt(key2, 0);
                    PlayerPrefs.Save();
                }
                else
                {
                    if(index == "lvl3")
                    {
                        PlayerPrefs.SetInt(key3, 0);
                        PlayerPrefs.Save();
                    }
                }
            }
            SceneManager.LoadScene("fail", LoadSceneMode.Single);
        }
        else
        {
            theText.text = "" + Mathf.Round(startingTime);
            if (mainBlock.transform.position.y >= pos.y)
            {
                if(Mathf.Round(startingTime) > 45)
                {
                    if(index == "lvl1")
                    {
                        PlayerPrefs.SetInt(key1, 3);
                        PlayerPrefs.Save();
                    }
                    else
                    {
                        if (index == "lvl2")
                        {
                            PlayerPrefs.SetInt(key2, 3);
                            PlayerPrefs.Save();
                        }
                        else
                        {
                            if (index == "lvl3")
                            {
                                PlayerPrefs.SetInt(key3, 3);
                                PlayerPrefs.Save();
                            }

                        } 
                    }
                    SceneManager.LoadScene("win1", LoadSceneMode.Single);

                }
                else
                {
                    if (Mathf.Round(startingTime) > 35 && Mathf.Round(startingTime) < 45)
                    {
                        if (index == "lvl1")
                        {
                            PlayerPrefs.SetInt(key1, 2);
                            PlayerPrefs.Save();
                        }
                        else
                        {
                            if (index == "lvl2")
                            {
                                PlayerPrefs.SetInt(key2, 2);
                                PlayerPrefs.Save();
                            }
                            else
                            {
                                if (index == "lvl3")
                                {
                                    PlayerPrefs.SetInt(key3, 2);
                                    PlayerPrefs.Save();
                                }

                            }
                        }
                        SceneManager.LoadScene("win2", LoadSceneMode.Single);
                    }
                    else
                    {
                        if (index == "lvl1")
                        {
                            PlayerPrefs.SetInt(key1, 1);
                            PlayerPrefs.Save();
                        }
                        else
                        {
                            if (index == "lvl2")
                            {
                                PlayerPrefs.SetInt(key2, 1);
                                PlayerPrefs.Save();
                            }
                            else
                            {
                                if (index == "lvl3")
                                {
                                    PlayerPrefs.SetInt(key3, 1);
                                    PlayerPrefs.Save();
                                }

                            }
                        }
                        SceneManager.LoadScene("win3", LoadSceneMode.Single);
                    }
                }
            }
        }
       
        
    }
}
