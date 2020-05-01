﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectFX : MonoBehaviour
{
  [SerializeField]
  private AudioClip soundfile;

  private AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    //void Update()
    //{

    //}

    void OnMouseDown ()
    {
      audioSrc.PlayOneShot(soundfile);
    }
}