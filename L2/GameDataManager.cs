using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class GameDataManager : MonoBehaviour
{
	public static int Score ;
	public Text ScoreText ;
	void Start(){
		Score = 0 ;
	}
	// Update is called every frame, if the MonoBehaviour is enabled.
	protected void Update()
	{
		ScoreText.text = "Score ："+Score ;
	}
}
