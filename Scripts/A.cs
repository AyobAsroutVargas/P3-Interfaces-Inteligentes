using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
  public B bReference;
  public GameObject cReference1;

  public C cReference;

  public delegate void mensaje3();
  public event mensaje3 OnCharacterCollideA;

  private Rigidbody m_rigidbody;
  public float upThrust = 20f;

  private Renderer myRenderer;

  // Start is called before the first frame update
  void Start()
  {
    bReference.OnCharacterCollideB += characterCollideB;
    cReference.OnCharacterClose += characterClose;
    m_rigidbody = GetComponent<Rigidbody>();
    myRenderer = GetComponent<Renderer>();
  }

  // Update is called once per frame
  void Update()
  {
        
  }

  private void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.CompareTag("Player"))
    {
      OnCharacterCollideA();
    }
    
  }
  void characterCollideB()
  {
    Debug.Log("Soy A");
    transform.position = Vector3.MoveTowards(transform.position, cReference1.transform.position, 100);

  }
  void characterClose()
  {
    Debug.Log("Soy A,c");
    m_rigidbody.AddForce(0, upThrust, 0);
    myRenderer.material.color = Color.blue;
  }
}
