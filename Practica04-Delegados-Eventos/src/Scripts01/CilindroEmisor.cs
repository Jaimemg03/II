using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CilindroEmisor : MonoBehaviour
{
  public delegate void CubeCollisionHandler();
  public static event CubeCollisionHandler OnCubeCollision;

  private void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.CompareTag("Cube"))
    {
      Debug.Log("Cilindro: colisión detectada con el cubo. Enviando mensaje a las esferas...");
      OnCubeCollision?.Invoke();
    }
  }
}
