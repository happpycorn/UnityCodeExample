using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followyou : MonoBehaviour
{
    public Transform target ;

    public Animator anim ;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(target.position, anim.rootPosition) > 2)
        {
            anim.SetFloat("speed",1) ;
            Vector3 currentDir = anim.rootRotation*Vector3.forward ;
            Vector3 wantedDir = (target.position - anim.rootPosition).normalized ;
            if (Vector3.Dot(currentDir, wantedDir) > 0)
            {
                anim.SetFloat("direction",Vector3.Cross(currentDir, wantedDir).y) ;
            }
            else
            {
                anim.SetFloat("direction",Vector3.Cross(currentDir, wantedDir).y > 0 ? 1f : -1f) ;
            }
        }
        else
        {
            anim.SetFloat("speed",0) ;
        }
    }
}
