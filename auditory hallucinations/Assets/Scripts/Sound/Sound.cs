using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    public string p_Name;

    public AudioClip p_Clip;

    [Range(0f,1f)]
    public float p_Volume;
    [Range(0.1f,3f)]
    public float p_Pitch;

    [Range(-1f, 1f)]
    public float p_StereoPan;

    public bool p_loop;

    [HideInInspector]
    public AudioSource p_Source;
}
