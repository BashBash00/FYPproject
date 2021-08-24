using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public GameObject ScoreScreen;
    public GameObject LoseScreen;
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

     public void PlayGame2 ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

     public void GoToMenu ()
     {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
     }

      public void GoToGrade ()
    {
      ScoreScreen.SetActive(true);
      LoseScreen.SetActive(false);
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT");
        Application.Quit();
        
    }
}
