using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Loads the next scene
  public void Gameplay ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        GameObject.FindGameObjectWithTag("mainMen").GetComponent<Music>().PlayingTheMusic();
    }

    // Quits the game
    public void GameQuit ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
