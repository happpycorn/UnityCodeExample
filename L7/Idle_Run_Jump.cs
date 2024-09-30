using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle_Run_Jump : MonoBehaviour
{
    public Animator animator ;

    private void Update() 
    {
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0) ;
        if (stateInfo.IsName("Base Layer.run"))
        {
            if (Input.GetButton("Fire1") || Input.GetButton("Jump"))
            {
                transform.position = new Vector3
                (
                    transform.position.x,
                    0,
                    transform.position.z
                ) ;
                animator.SetBool("jump",true) ;
            }
        }
        else
        {
            animator.SetBool("jump",false) ;
        }

        if (Input.GetButton("Fire2"))
        {
            animator.SetBool("wave", !animator.GetBool("wave")) ;
        }

        float v = Input.GetAxis("Vertical") ;
        animator.SetFloat("speed",v) ;

        float h = Input.GetAxis("Horizontal") ;
        animator.SetFloat("direction",h) ;

        // if (Input.GetButton("Fire1"))
        // {
        //     animator.SetBool("jump",true) ;
        // }
        // else
        // {
        //     animator.SetBool("jump",false) ;
        // }
    }
}
