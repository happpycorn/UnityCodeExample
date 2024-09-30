using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
	
	public int speed = 5;
	
	public bool onland;
	
	public GameObject idle ;
	
	public GameObject Jumpmodel ;
	
	public GameObject busidle ;
	
	public GameObject busJump ;
	
	public int score ;
	
	public ParticleSystem boom ;
	
	public AudioSource audioSource ;
	
	public AudioClip audioClip ;
	
	void Start()
	{
		idle.SetActive(false) ;
		Jumpmodel.SetActive(true) ;
	}
	
	void Update()
	{
		score = GameDataManager.Score ;
		if (onland == true) 
		{
		    if (Input.GetMouseButtonDown(0)) {
		    	
		    	onland = false ;
		    	if(score<5){
		    		idle.SetActive(false) ;
			    	Jumpmodel.SetActive(true) ;
		    	}else{
		    		busidle.SetActive(false) ;
			    	busJump.SetActive(true) ;
		    	}


		    	this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,1,0)*speed;
		    	
		    }
		}
		if (score>4){
			if(onland != true){
				idle.SetActive(false) ;
				Jumpmodel.SetActive(false) ;
				busJump.SetActive(true) ;
			}else{
				busidle.SetActive(true) ;
				idle.SetActive(false) ;
				Jumpmodel.SetActive(false) ;
			}
		}
    }
    
	protected void OnCollisionEnter(Collision collisionInfo)
	{
		if(collisionInfo.gameObject.tag == "Floor")
		{
			onland=true;
			if(score<5){
				idle.SetActive(true) ;
				Jumpmodel.SetActive(false) ;
			}else{
				busidle.SetActive(true) ;
				busJump.SetActive(false) ;
			}
		}
		if(collisionInfo.gameObject.tag == "Untagged")
		{
			boom.Play() ;
			audioSource.PlayOneShot(audioClip) ;
		}
	}
}
