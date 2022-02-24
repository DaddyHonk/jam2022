using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Finish : MonoBehaviour
{
    
    void Update()
    {
        if (PlayerPrefs.GetInt("Pictures" + 0) == 1 && PlayerPrefs.GetInt("Pictures" + 1) == 1 && PlayerPrefs.GetInt("Pictures" + 2) == 1 && PlayerPrefs.GetInt("Pictures" + 3) == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}
