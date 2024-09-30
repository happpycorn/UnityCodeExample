using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour
{
    public ParticleSystem particl ;
    public AudioSource audioSource ;
    public AudioClip audioClip ;
    public void Onclick()
    {
        particl.Play() ;
        audioSource.PlayOneShot(audioClip) ;
    }
}
