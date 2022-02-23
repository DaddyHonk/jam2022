using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound : MonoBehaviour
{
        // hellen code is uit dit filmpje gehaald https://youtu.be/6OT43pvUyfY
        public string p_Name;

        public AudioClip p_Clip;

        [Range(0f, 1f)]
        public float p_Volume;
        [Range(.1f, 3f)]
        public float p_Pitch;

        public bool p_Loop;

        [HideInInspector]
        public AudioSource p_source;
}
