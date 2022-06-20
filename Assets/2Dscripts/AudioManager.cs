using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip sound;
    public AudioClip sound1;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SE()
    {
        audioSource.PlayOneShot(sound);
    }
    public void SE2()
    {
        audioSource.PlayOneShot(sound1);
    }
}
