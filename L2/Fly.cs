using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class Fly : MonoBehaviour
{
	public Vector3 speed;
	public Text ScoreText ;
	public add_obj Scoreint ;
	public int Score = GameDataManager.Score ;
	public ParticleSystem boom ;

	void Start()
    {
	    GetComponent<Rigidbody>().velocity = speed;
    }
    
	void OnBecameInvisible()
	{
		Destroy(this.gameObject) ;
	}
	protected void OnCollisionEnter(Collision collisionInfo)
	{
		if(collisionInfo.gameObject.tag == "Player")
		{
			//boom.Play() ;
			Destroy(this.gameObject) ;
			GameDataManager.Score++;
			Score += 1 ;
			//this.gameObject.SetActive(false) ;
			//Debug.Log("colli!") ;
			//Scoreint.score = Score ;
			//ScoreText.text = "Score"+Scoreint.score ;
		}
	}
}
