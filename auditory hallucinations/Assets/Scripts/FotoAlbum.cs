using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FotoAlbum : MonoBehaviour
{
    [SerializeField] private GameObject p_Photo1;
    [SerializeField] private GameObject p_Photo2;
    [SerializeField] private GameObject p_Photo3;
    [SerializeField] private GameObject p_Photo4;
    void Update()
    {
        if (PlayerPrefs.GetInt("Pictures" + 0) == 1)
            p_Photo1.SetActive(true);
        if (PlayerPrefs.GetInt("Pictures" + 1) == 1)
            p_Photo2.SetActive(true);
        if (PlayerPrefs.GetInt("Pictures" + 2) == 1)
            p_Photo3.SetActive(true);
        if (PlayerPrefs.GetInt("Pictures" + 3) == 1)
            p_Photo4.SetActive(true);
    }
}
