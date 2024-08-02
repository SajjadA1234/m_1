using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class guid : MonoBehaviour
{
    public void goTONextScence()
    {
        SceneManager.LoadScene("rain4");
        Time.timeScale = 1;
    }
    public void goTOMenu()
    {
        SceneManager.LoadScene("Menu");
    }

     public void goTOpoori()
    {
        SceneManager.LoadScene("poori");
        Time.timeScale = 1;
    }

     public void goTOAbout()
    {
        SceneManager.LoadScene("About");
    }
}
