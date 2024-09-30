using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject wall ;
    public Vector3 pos ;

    public float timer ;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime ;
        if (timer > 3)
        {
            pos = this.gameObject.transform.position ;
            this.gameObject.transform.position += new Vector3(0, Random.Range(-2, 2),0) ;
            Instantiate(wall, transform.position, transform.rotation) ;
            timer = 0 ;
            this.gameObject.transform.position = pos ;
        }
    }

}
