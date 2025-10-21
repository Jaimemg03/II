using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboEmisor : MonoBehaviour
{
  public float speed = 5.0f;
  private Collider collider;
  private Vector3 moveInput;

  public delegate void CubeCollisionHandler();
  public static event CubeCollisionHandler OnType1Collision;
  public static event CubeCollisionHandler OnType2Collision;

  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("Type1")) {
      Debug.Log("Cubo: colisión detectada con Type1. Enviando mensaje a Type2...");
      OnType1Collision?.Invoke();
    }

    if (other.gameObject.CompareTag("Type2"))
    {
      Debug.Log("Cubo: colisión detectada con Type2. Enviando mensaje a Type1...");
      OnType2Collision?.Invoke();
    }
  }

  
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
    }

    // Called every fixed framerate frame
    void FixedUpdate()
    {
      float moveX = Input.GetAxis("Horizontal");
      float moveZ = Input.GetAxis("Vertical");

      Vector3 movement = new Vector3(moveX, 0, moveZ);
      transform.position += movement * speed * Time.fixedDeltaTime;
    }
}