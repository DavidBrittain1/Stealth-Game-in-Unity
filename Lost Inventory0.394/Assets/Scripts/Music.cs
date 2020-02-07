﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
 
    private AudioSource audioSource;
    private void Awake()
    {
       DontDestroyOnLoad (transform.gameObject);
        audioSource = GetComponent<AudioSource>();
    }
    public void PlayingTheMusic()
    {
        if (audioSource.isPlaying) return;
        audioSource.Play();
    }

    public void StoppingTheMusic()
    {
        audioSource.Stop();
    }

}
