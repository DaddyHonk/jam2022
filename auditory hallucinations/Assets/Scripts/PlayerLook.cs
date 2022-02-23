using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public SpriteRenderer spriterender;
    public SpriteRenderer spriterender2;
    public Vector3 directionvectortomouse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousposinworld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        directionvectortomouse = mousposinworld - transform.position;


        if (directionvectortomouse.x <= 0)
        {
            spriterender.flipX = true;
            spriterender2.flipX = true;
        }
        else
        {
            spriterender.flipX = false;
            spriterender2.flipX = false;
        }
    }
}
