using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class around : MonoBehaviour {
	public Transform center ;
	public float speed = 10 ;
	void Update () {
		this.transform.RotateAround(center.position, Vector3.up, speed) ;
	}
}
