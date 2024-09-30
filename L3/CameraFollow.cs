using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform bird ;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3
        (
            bird.position.x,
            transform.position.y,
            transform.position.z
        ) ;
    }
}
