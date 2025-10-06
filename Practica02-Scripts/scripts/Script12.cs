using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script12 : MonoBehaviour
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
    if (esfera == null) return;

    // Hacer que el cubo mire hacia la esfera (solo en el plano XZ)
    Vector3 objetivo = esfera.position;
    objetivo.y = transform.position.y; // Mantener la altura del cubo
    transform.LookAt(objetivo);

    // Avanzar hacia adelante en su propio eje Z
    transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
  }
}