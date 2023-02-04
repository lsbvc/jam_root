using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    //Matriz musica 
    public AudioSource[] music;
    public AudioSource[] sfx; //Efectos de sonido
    public AudioSource[] keys;
    public AudioSource[] traslation;
    private int rkey;

    private int rtras;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        PlayMusic(1);
    }
    private void Update()
    {
        
      
    }

    public void PlayMusic(int musicToPlay)
    {
        music[musicToPlay].Play();
    }
    public void PlaySFX(int sfxToPlay)
    {
        sfx[sfxToPlay].Play();
    }
    public void PlayKeys(int keyToPlay)
    {
        rkey = Random.Range(0, keys.Length - 1);
        // keys[keyToPlay].Play();
        keys[rkey].Play();
    }
    public void PlayTraslation()
    {
        rtras = Random.Range(0, traslation.Length - 1);
        traslation[0].Play();
    }
    public void StopTraslation()
    {
        traslation[0].Stop();
    }
}