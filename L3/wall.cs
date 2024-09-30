using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    public Rigidbody2D rb2d ;
    public float speed ;

//     private void Start() 
//     {
//         rb2d.velocity = Vector2.down * speed ;
//         InvokeRepeating("SwitchMove",2f,2f) ;
//         StartCoroutine(SwitchMoveRoutine()) ;
//     }

    private void Start() 
    {
        speed = Random.Range(0.5f,2f) ;
        rb2d.velocity = Vector2.up * speed ;
        StartCoroutine(SwitchMoveRoutineWhile()) ;
    }

    private void SwitchMove()
    {
        rb2d.velocity *= -1 ;
    }

    IEnumerator SwitchMoveRoutine()
    {
        yield return new WaitForSeconds(2f) ;
        SwitchMove() ;
        StartCoroutine(SwitchMoveRoutine()) ;
    }

    IEnumerator SwitchMoveRoutineWhile()
    {
        while(true)
        {
            yield return new WaitForSeconds(2f) ;
            SwitchMove() ;
        }
    }

//     public bool isup ;
//     public float timer = 0 ;

//     public void wup()
//     {
//         rb2d.velocity = Vector2.up * speed ;
//         Invoke("wdown",2f) ;
//     }
//     public void wdown()
//     {
//         rb2d.velocity = Vector2.down * speed ;
//         Invoke("wup",2f) ;
//     }
//     private void Start() 
//     {
//         wdown() ;
//     }

//    // Update is called once per frame
//     void Update()
//     {    
//         timer += Time.deltaTime ;
//         //Debug.Log("time "+timer) ;
//         if (timer > 2f)
//         {
//             if (isup)
//             {
//                 wup() ;
//                 isup = false ;
//             }
//             else
//             {
//                 wdown() ;
//                 isup = true ;
//             }
//             timer = 0 ;
//         }
//     }
    void OnBecameInvisible()
	{
		Destroy(this.gameObject) ;
	}
}
