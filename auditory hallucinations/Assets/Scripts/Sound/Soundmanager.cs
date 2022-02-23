using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class Soundmanager : MonoBehaviour
{
    public Sound[] p_Sounds;

    void Awake()
    {
        foreach (Sound s in p_Sounds)
        {
            s.p_source = gameObject.AddComponent<AudioSource>();
            s.p_source.clip = s.p_Clip;

            s.p_source.volume = s.p_Volume;
            s.p_source.pitch = s.p_Pitch;
        }
    }

    public void Play (string name)
    {
        Sound s = Array.Find(p_Sounds, Sound => Sound.name == name);
        if(s = null) { return; }
        if(s.p_source.isPlaying == false)
            s.p_source.Play();
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(p_Sounds, Sound => Sound.p_Name == name);
        if (s = null) { return; }

        s.p_source.Stop();
    }
}
