using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource bgm;
    public AudioClip[] bgmclip;
    // Start is called before the first frame update
    void Start()
    {
        bgm.clip = bgmclip[Random.Range(0, bgmclip.Length)];
        bgm.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
