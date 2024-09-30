using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class set : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = new Vector3 (transform.position.x,0.6f,transform.position.z) ;
    }
}
