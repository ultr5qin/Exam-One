using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameBehaviour : MonoBehaviour
{

    public bool frozenTime = true;
    public float timeRemaining = 60;
    public Text timed;

    void Start()
    {
        frozenTime = false;
    }

    void Update()
    {
        if(frozenTime == false)
        {
            if(timeRemaining >= 1)
            {
                timeRemaining = timeRemaining - Time.deltaTime;
                Timer(timeRemaining);
            }
            else
            {
                frozenTime = true;
            }
        }
        else
        {
            timeRemaining = 0;
            SceneManager.LoadScene(2);

        }
        
    }

    public void Timer(float time)
    {
        float s = Mathf.FloorToInt(time % 60);
        timed.text = string.Format("{00}", s);
    }

    public void SwitchToSceneTwo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
