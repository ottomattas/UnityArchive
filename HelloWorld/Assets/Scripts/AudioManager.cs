using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    // Create public array for sounds
    public Sound[] sounds;
    
    // Awake is called before the Start method
    void Awake()
    {
        // For each sound s in our sounds array
        foreach(Sound s in sounds)
        {
            // Define the parameters in array
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    // Create a method to play a certain sound directly from source
    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
}
