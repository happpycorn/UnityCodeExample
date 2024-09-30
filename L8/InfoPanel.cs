using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class InfoPanel : MonoBehaviour {
	public  Text textObj ;
	public int number ;
	private void Start() {
		textObj.text = "這是神奇的神燈"+number+"號" ;
	}
}
