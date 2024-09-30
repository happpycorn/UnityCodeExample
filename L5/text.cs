using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class text : MonoBehaviour
{
    public GameObject txt ;
    public GameObject pla ;
    public GameObject tip ;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("disable",3) ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void disable()
    {
        txt.SetActive(false) ;
        pla.SetActive(false) ;
        tip.SetActive(true) ;
    }
}
