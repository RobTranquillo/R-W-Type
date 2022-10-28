using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbienceAudio : MonoBehaviour
{
    public AudioClip ambienceAudio;
    public AudioSource source;

    void Start()
    {
        if (ambienceAudio != null)
            return;
        if (source == null) 
            source = GetComponent<AudioSource>();
        source.clip = ambienceAudio;
        source.Play();
    }
}
