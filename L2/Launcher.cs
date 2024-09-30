using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
	public GameObject ballprefab ;
	
	// Update is called once per frame
    void Update()
    {
	    if (Input.GetMouseButtonDown(1))
	    {
	    	Instantiate(ballprefab) ;
	    }
    }
}
