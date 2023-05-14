using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class GameplayMusicController : MonoBehaviour
{
    public AudioSource gameMusic;

    void Start()
    {
        gameMusic.Play();
    }
}
