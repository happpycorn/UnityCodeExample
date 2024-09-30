using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendTree2d : MonoBehaviour
{
    public Animator anim ;

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical") ;
        float h = Input.GetAxis("Horizontal") ;

        anim.SetFloat("xVal",h,0.25f,Time.deltaTime) ;
        anim.SetFloat("yVal",v,0.25f,Time.deltaTime) ;
    }
}
