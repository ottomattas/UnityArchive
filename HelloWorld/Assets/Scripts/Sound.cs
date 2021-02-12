using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

// Make it serializable
[System.Serializable]

// Create a sound class
public class Sound
{

    // Name the audio clip
    public string name;

    // Reference to the audio clip
    public AudioClip clip;

    // Add slider to volume with min/max
    [Range(0f, 1f)]
    // Reference to the audio volume
    public float volume;

    // Add slider to pitch with min/max
    [Range(.1f, 3f)]

    // Reference to the audio pitch
    public float pitch;
    
    // Reference the audio source and hide in inspector
    // because we want to call this automatically. It is public but won't show
    [HideInInspector]
    public AudioSource source;
    
}
