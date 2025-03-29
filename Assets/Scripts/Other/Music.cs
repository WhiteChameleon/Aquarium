using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{
    public AudioSource audioSounds;
    void Start()
    {
        audioSounds = GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "CutScene")
        {
            audioSounds.mute = true;
        }
        else
        {
            audioSounds.mute = false;
        }
    }
}
