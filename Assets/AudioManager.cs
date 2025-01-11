using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayMusic("Bgm");
    }

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds,(x) =>x.name == name);
        if (s == null)
        {
            Debug.Log("musicMissing");
        }
        else {
            musicSource.clip = s.clip;
            musicSource.Play();
        }

    }
    public void PlaySfx(string name)
    {
        Sound s = Array.Find(musicSounds, (x) => x.name == name);
        if (s == null)
        {
            Debug.Log("sfxMissing");
        }
        else
        {
            sfxSource.PlayOneShot(s.clip);
        }
    }
}
