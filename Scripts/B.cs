using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B : MonoBehaviour
{
  public A aReference;

  public C cReference;

  public delegate void mensaje2();
  public event mensaje2 OnCharacterCollideB;

  public Transform targetRotation;

  // Start is called before the first frame update
  void Start()
  {
    aReference.OnCharacterCollideA += characterCollideA;
    cReference.OnCharacterClose += characterClose;
  }

    // Update is called once per frame
    void Update()
    {
      Vector3 forward = transform.TransformDirection(Vector3.forward) * 300;
      Debug.DrawRay(transform.position, forward, Color.red);
  }

  private void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.CompareTag("Player"))
    {
      OnCharacterCollideB();
    }
  }


  void characterCollideA()
  {
    Debug.Log("Soy B");
    transform.localScale = transform.localScale * 1.2f;
  }
  void characterClose()
  {
    transform.LookAt(targetRotation);
  }
}
