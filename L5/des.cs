using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class des : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "biu")
        {
            Destroy(this.gameObject) ;
        }
    }
}
