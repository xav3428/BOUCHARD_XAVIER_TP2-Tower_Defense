using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BackGroundMusicSwitch : MonoBehaviour
{
    public static BackGroundMusicSwitch musicmanager;

    public AudioSource musique;
    public AudioSource mobs;
    public AudioSource towers;
    public AudioClip[] musics;

    private void Awake()
    {
        musicmanager = this;
    }

    private void Start()
    {
        StartCoroutine(togglebetweenmusic());
    }

    IEnumerator togglebetweenmusic()
    {
        while (true)
        {
            for (int i = 0; i < musics.Length; i++)
            {
                // We play the music next in the loop
                musique.PlayOneShot(musics[i]);

                // This waits for the end of the currently playing soundbite
                yield return new WaitForSecondsRealtime(musics[i].length);
            }
        }
    }
}
