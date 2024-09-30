using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Birds : MonoBehaviour
{

    public float speed = 1 ;
    public float jump = 300 ;
    public Rigidbody2D rb2d ;

    // Start is called before the first frame update
    void Start()
    {
        rb2d.velocity = Vector2.right * speed ;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(Vector2.up * jump) ;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        //Application.LoadLevel(Application.loadedLevel) ;
        if (other.gameObject.tag == "Respawn"){
            score.Score++ ;
        }else{
            SceneManager.LoadScene("Game") ;
        }
    }
}
