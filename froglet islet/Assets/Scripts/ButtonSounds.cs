﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSounds : MonoBehaviour
{
     public AudioClip sfx1;
     public AudioClip sfx2;
     public AudioClip sfx3;
     public AudioClip sfx4;
     public AudioSource sfxPlayer;

     void Start()
     {
          GetComponent<AudioSource>().time = GetComponent<AudioSource>().clip.length * .5f;
     }
    public void OnClick(int buttonNum)
    {
        switch(buttonNum)
        {
            case 1:
                sfxPlayer.PlayOneShot(sfx1, 1f);
                break;
            case 2:
                sfxPlayer.PlayOneShot(sfx2, 1f);
                break;
            case 3:
                sfxPlayer.PlayOneShot(sfx3, 1f);
                break;
            case 4:
                sfxPlayer.PlayOneShot(sfx4, 1f);
                break;
        }
    }
}
