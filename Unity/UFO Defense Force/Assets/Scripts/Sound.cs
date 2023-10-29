using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;
using System;

[System.Serializable]
public class Sound
{
    public string name;
    public AudioClip clip;
    [Range(0f,1f)]
    public float volume;
    public float pitch = 1f;

    [HideInInspector]
    public AudioSource source;

}
