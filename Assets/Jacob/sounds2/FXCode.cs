using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXCode : MonoBehaviour
{
    [SerializeField]
    private AudioClip soundfile;

    private AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    public void PlayDownSound()
    {
        audioSrc.PlayOneShot(soundfile);
    }
}
