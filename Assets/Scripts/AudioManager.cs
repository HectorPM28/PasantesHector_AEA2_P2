using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    [SerializeField] private List<AudioClip> audios;
    [SerializeField] private AudioSource sfxAudioSource;
    [SerializeField] private AudioSource bgAudioSource;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bgAudioSource.clip = audios[0];
        bgAudioSource.Play();
    }
    public void PlaySound(int soundIndex)
    {
        sfxAudioSource.PlayOneShot(audios[soundIndex]);
    }
}
