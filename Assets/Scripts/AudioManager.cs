using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    private AudioSource _source;

    void Awake()
    {
        instance = this;
        // DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        _source = GetComponent<AudioSource>();
    }

    public void PlaySFX(AudioClip clip)
    {
        _source.PlayOneShot(clip);
    }
}
