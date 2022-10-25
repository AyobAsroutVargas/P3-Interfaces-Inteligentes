using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
  private CharacterController controller;
  public float speed = 5f;
  public float rotationSpeed = 100f;
  // Start is called before the first frame update
  void Start()
  {
    controller = GetComponent<CharacterController>();
  }

    // Update is called once per frame
    void Update()
    {
      Vector3 movement = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");
      float rotationAxis = Input.GetAxis("YRotation");
      Vector3 rotation = transform.up * rotationAxis * rotationSpeed * Time.deltaTime;
      transform.Rotate(rotation);


      controller.Move(movement * speed * Time.deltaTime);
    

      Vector3 forward = transform.TransformDirection(Vector3.forward) * 300;
      Debug.DrawRay(transform.position, forward, Color.red);
    }
}
