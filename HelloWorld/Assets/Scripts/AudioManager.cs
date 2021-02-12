using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

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

    // Update is called once per frame
    void Update()
    {
        
    }
}
