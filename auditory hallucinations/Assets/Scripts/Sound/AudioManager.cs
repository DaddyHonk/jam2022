using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] p_Sounds;
    void Awake()
    {

        foreach (Sound s in p_Sounds)
        {
            s.p_Source = gameObject.AddComponent<AudioSource>();
            s.p_Source.clip = s.p_Clip;

            s.p_Source.volume = s.p_Volume;
            s.p_Source.pitch = s.p_Pitch;
            s.p_Source.loop = s.p_loop;
        }
    }

    private void Start()
    {
        Play("the amalgamtion - speech");
    }

    public void Play(string name)
    {
        Sound s = Array.Find(p_Sounds, sound => sound.p_Name == name);
        if (s == null)
            return;
        s.p_Source.Play();
    }
}
