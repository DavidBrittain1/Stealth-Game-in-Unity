using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TimeUp : MonoBehaviour
{
    public void retryLevel()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }
    public void exitToMenu()
        {
            SceneManager.LoadScene("Main Menu");
        }
    


    
}
