using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CuboPoints6 : MonoBehaviour
{
  public float speed = 5.0f;
  public TMP_Text pointTxt;
  private Rigidbody rb;
  private Vector3 moveInput;
  private int puntuacion = 0;

  private void Update() {
    moveInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
  }


    private void OnTriggerEnter(Collider other)
    {
        // Detecta colisión con escudos
        if (other.CompareTag("Type1"))
        {
            puntuacion += 5;
            Debug.Log($"Has recogido Escudo1. Puntuación: {puntuacion}");
            Destroy(other.gameObject); // Opcional: eliminar escudo al recoger
        }
        else if (other.CompareTag("Type2"))
        {
            puntuacion += 10;
            Debug.Log($"Has recogido Escudo2. Puntuación: {puntuacion}");
            Destroy(other.gameObject); // Opcional: eliminar escudo al recoger
        }
        if (pointTxt != null)
          pointTxt.text = "Puntuación: " + puntuacion;
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
