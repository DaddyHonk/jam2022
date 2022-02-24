using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlash : MonoBehaviour
{
    public GameObject FovBlocker;
    public bool Disable = false;
    public float coolDown = 1f;
    public float coolDownTimer;
    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.Mouse1) && coolDownTimer == 0)
        {
            FovBlocker.SetActive(true);

        }
        else
        {
            FovBlocker.SetActive(false);
        }
    }
}
