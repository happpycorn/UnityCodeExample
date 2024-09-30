using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    public string sencename ;
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player"){

            SceneManager.LoadScene(sencename) ;
        }
    }
}
