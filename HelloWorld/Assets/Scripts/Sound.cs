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

    // Reference to the audio pitch
    public float pitch;
    
}
