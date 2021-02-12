using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    // Create public array for sounds
    public Sound[] sounds;
    
    // Static reference to the AudioManager instance
    public static AudioManager instance;
    
    // Awake is called before the Start method
    void Awake()
    {
        // Check for previous audiomanager instance
        if (instance == null)
            // Set instance to this game object
            instance = this;
        else
        {
            // Destroy the object not to spin new one up
            // as we keep it persistent below
            Destroy(gameObject);
            // To make sure not anything else
            // is called before Destory, we return
            return;
        }
        // For each sound s in our sounds array
        foreach(Sound s in sounds)
        {
            // Get current gameobject and add it to audiosource
            s.source = gameObject.AddComponent<AudioSource>();
            // Define the parameters in array
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    // Create start method to call theme music
    void Start()
    {
        Play("Theme");
    }

    // Create a method to play a certain sound directly from source
    public void Play (string name)
    {
        // Store the sound in variable s
        Sound s = Array.Find(sounds, sound => sound.name == name);
        
        // If no sound with sound.name exists, simply return (to avoid error)
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        // Play source
        s.source.Play();
    }
}
