using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script13 : MonoBehaviour
{
  public float speed = 2f;
  private Transform esfera;

  void Start()
  {
    // Busca la esfera por su etiqueta (asegúrate de que la tenga)
    GameObject obj = GameObject.FindWithTag("esfera");
    if (obj != null)
      esfera = obj.transform;
  }

  void Update()
  {
    // Girar con el eje horizontal
    float giro = Input.GetAxis("Horizontal");
    transform.Rotate(0, giro * 100f * Time.deltaTime, 0); // 100f es la velocidad de giro, ajusta si quieres

    // Avanzar siempre hacia adelante (eje Z local)
    transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);

    // Dibuja un rayo para ver la dirección forward
    Debug.DrawRay(transform.position, transform.forward * 2, Color.red);
  }
}