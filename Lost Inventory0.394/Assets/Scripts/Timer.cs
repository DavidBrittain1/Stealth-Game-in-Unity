using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public static bool isTimeUp = false;
    public GameObject timesUp;
    float startTime = 300f;
    float thisTime = 0f;
    [SerializeField] Text timerText;



    void Start()
    {
        timesUp = GameObject.Find("timesUpMenu");
        timesUp.SetActive(false);
        thisTime = startTime;
    }

     void Update()
    {
       
        
        thisTime -= 1 * Time.deltaTime;
        timerText.text = thisTime.ToString("0");

        if(thisTime <= 0)
        {
            timesUp.SetActive(true);
            thisTime = 0;
            timerText.color = Color.red;
        }
    }

    public void retryLevel()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }
    public void exitToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }


}
