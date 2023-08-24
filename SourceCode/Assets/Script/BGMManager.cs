using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    public AudioSource bgm;

    void Start()
    {
        PlayBGM();
    }

    private void PlayBGM()
    {
        bgm.Play();
    }
}
