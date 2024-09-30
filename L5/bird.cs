using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public AudioSource audioSource ;
    public AudioClip audioClip;

    private void OnCollisionEnter(Collision Col) 
    {
        if (Col.relativeVelocity.magnitude > 14f){
            audioSource.PlayOneShot(audioClip) ;
        }
    }
}
