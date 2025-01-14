﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class AudioSourceController : MonoBehaviour
{
    private static AudioSourceController m_instance;
    public static AudioSourceController instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = FindObjectOfType<AudioSourceController>();

                if (m_instance == null)
                {
                    m_instance = new GameObject("AudioSourceController").AddComponent<AudioSourceController>();
                }
            }
            return m_instance;
        }
    }

    AudioSource audioSource;

    new AudioSource audio
    {
        get
        {
            if (audioSource == null)
            {
                audioSource = GetComponent<AudioSource>();
            }

            return audioSource;
        }
    }


    public void PlayOneShot(AudioClip clip)
    {
        audio.PlayOneShot(clip);
    }
}
