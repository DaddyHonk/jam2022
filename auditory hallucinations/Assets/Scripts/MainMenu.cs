using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int change;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + change);
        PlayerPrefs.SetInt("Pictures" + 0, 0);
        PlayerPrefs.SetInt("Pictures" + 1, 0);
        PlayerPrefs.SetInt("Pictures" + 2, 0);
        PlayerPrefs.SetInt("Pictures" + 3, 0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
