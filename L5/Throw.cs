using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    public GameObject birdprefab ;
    public float speed ;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            GameObject newObj = Instantiate(birdprefab) ;
            newObj.GetComponent<Rigidbody>().position = transform.position ;
            newObj.GetComponent<Rigidbody>().velocity = transform.forward * speed ;
            Destroy(newObj, 3f) ;
            // StartCoroutine(DestroyObj(newObj)) ;
        }
    }

//     private IEnumerator DestroyObj(GameObject obj)
//     {
//         yield return new WaitForSeconds(3f) ;
//         Destroy(obj) ;
//     }
}
