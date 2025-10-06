using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script11 : MonoBehaviour
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

    // Calcula el vector dirección en el plano XZ (sin cambiar la altura)
    Vector3 destino = esfera.position;
    destino.y = transform.position.y;
    Vector3 miVector = destino - transform.position;

    // Normaliza el vector para que la magnitud sea 1
    Vector3 direccion = miVector.normalized;

    // Mueve el cubo hacia la esfera a velocidad constante
    transform.Translate(direccion * speed * Time.deltaTime, Space.World);
  }
}