using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator door ;
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "biu")
        {
            door.SetBool("open",false) ;
        }
    }
}
