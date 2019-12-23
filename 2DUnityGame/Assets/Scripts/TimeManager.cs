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


        if( Mathf.Round(startingTime) == 0 )
        {
            theText.text = "" + Mathf.Round(startingTime);
            SceneManager.LoadScene("fail", LoadSceneMode.Single);
        }
        else
        {
            theText.text = "" + Mathf.Round(startingTime);
            if (mainBlock.transform.position.y >= pos.y)
            {
                if(Mathf.Round(startingTime) > 45)
                {
                    SceneManager.LoadScene("win1", LoadSceneMode.Single);

                }
                else
                {
                    if (Mathf.Round(startingTime) > 35 && Mathf.Round(startingTime) < 45)
                    {
                        SceneManager.LoadScene("win2", LoadSceneMode.Single);
                    }
                    else
                    {
                        SceneManager.LoadScene("win3", LoadSceneMode.Single);
                    }
                }
            }
        }
       
        
    }
}
