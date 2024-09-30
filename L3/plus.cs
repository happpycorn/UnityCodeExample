using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plus : MonoBehaviour
{
    public gamedata scoreso ;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player")
        {
            score.Score++ ;
            if (score.Score > scoreso.score){
                scoreso.score = score.Score ;

            }
        }
    }
}
