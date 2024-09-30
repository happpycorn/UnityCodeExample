using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigpig : MonoBehaviour
{
    public GameObject next ;
    public GameObject pig ;
    public Animator door ;
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "biu")
        {
            door.SetBool("open",false) ;
            next.SetActive(true) ;
            Destroy(this.gameObject) ;
            CreatPig() ;
        }
    }

    private void CreatPig()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject pigv = Instantiate(pig,transform.position,transform.rotation) ;
            Destroy(pigv) ;
        }
    }
}
