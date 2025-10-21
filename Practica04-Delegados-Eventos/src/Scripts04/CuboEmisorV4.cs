using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboEmisorV4 : MonoBehaviour
{
  public float speed = 5.0f;
  private Rigidbody rb;
  private Vector3 moveInput;
  public Transform referenceObject;
  public float activationDistance = 2f;

  public delegate void CubeCollisionHandler();
  public static event CubeCollisionHandler OnCollision;

  private void Update() {
    moveInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
    if (referenceObject == null) return;

    float distancia = Vector3.Distance(transform.position, referenceObject.position);
    if (distancia <= activationDistance)
    {
    Debug.Log("Cubo: objeto de referencia alcanzado. Activando grupos...");

      // Notificar a los grupos
      OnCollision?.Invoke();

        // Evitar dispararlo cada frame
      enabled = false;
    }
  }

    
  // Start is called before the first frame update
  void Start()
  {
      rb = GetComponent<Rigidbody>();
  }

  // Called every fixed framerate frame
  void FixedUpdate()
  {
      rb.MovePosition(rb.position + moveInput * speed * Time.fixedDeltaTime);
  }
}
