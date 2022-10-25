using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C : MonoBehaviour
{
  public GameObject player;

  public float minDistance = 150;
  private bool isClose = false;

  public delegate void mensaje1();
  public event mensaje1 OnCharacterClose;
  // Start is called before the first frame update
  void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      float distance = Vector3.Distance(transform.position, player.transform.position);
      if (distance < minDistance && !isClose)
      {
        OnCharacterClose();
        isClose = true;
      }
      else if (distance > minDistance)
      {
        isClose = false;
      }
  }
}
