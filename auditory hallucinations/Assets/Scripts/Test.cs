using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Vector3 p_MousePosition = Vector3.zero;
    [SerializeField] private GameObject p_Camera;
    [SerializeField] private GameObject p_CameraFlits;
    [SerializeField] private GameObject[] p_Pictures;
    private int p_PictureInt;

    private void Start()
    {
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update()
    {

        p_MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        p_Camera.transform.position = new Vector3(p_MousePosition.x, p_MousePosition.y + 1f, 0f);

        if (Input.GetMouseButtonDown(0) == true)
        {
            Debug.Log("Test");
            StartCoroutine(Flits());
            if (p_Pictures[p_PictureInt].transform.position == p_MousePosition)
            {
                SavePicture();
            }
        }
    }

    public IEnumerator Flits()
    {
        p_CameraFlits.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        p_CameraFlits.SetActive(false);
    }

    void SavePicture()
    {
        PlayerPrefs.SetInt("Pictures" + p_PictureInt, 1);
        PlayerPrefs.Save();
        p_PictureInt++;
    }
}
