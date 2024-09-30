using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class Teleport : MonoBehaviour
{

  public float timeSpendGazeAt = 0f;
  public bool isGazingAtObject = false;
  public bool isMovingTowardObject = false;
  public Transform player;
  public float speed = 2f;
  public Collider myCollider ;
  public float distance = 0.1f ;

  private void Start() {
    player = GameObject.Find("Player").transform ;
    myCollider = GetComponent<Collider>() ;
  }
  void Update()
  {
    if (isGazingAtObject == true)
    {
      timeSpendGazeAt += Time.deltaTime;
    }
    if (timeSpendGazeAt > 2f)
    {
      isGazingAtObject = false;
      isMovingTowardObject = true;
      timeSpendGazeAt = 0f;
    }
    if (isMovingTowardObject == true)
    {
      player.transform.position = Vector3.MoveTowards(
        player.position,
        transform.position,
        Time.deltaTime * speed
      );
    }
    if (player.position == transform.position ||
    Vector3.Distance(player.position, transform.position) < distance)
    {
      isMovingTowardObject = false;
      myCollider.enabled = false ;
    }else{
      myCollider.enabled = true ;
    }
  }

  public void OnGazeEnter()
  {
    isGazingAtObject = true ;
    timeSpendGazeAt = 0 ;
  }

  public void OnGazeExit()
  {
    isGazingAtObject = false ;
  }
}
