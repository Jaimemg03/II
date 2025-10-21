using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTypes : MonoBehaviour
{
    public Transform objectReference;      // Referencia al objeto de referencia

    private void OnEnable()
    {
        // Suscribirse al evento del cubo
        if (gameObject.CompareTag("Type1")) {
            CuboEmisorV4.OnCollision += Teletransportar;
        }
        if (gameObject.CompareTag("Type2")) {
            CuboEmisorV4.OnCollision += Orientar;
        }
    }

    private void OnDisable()
    {
        // Cancelar suscripción al evento del cubo
        if (gameObject.CompareTag("Type1")) {
            CuboEmisorV4.OnCollision -= Teletransportar;
        }
        if (gameObject.CompareTag("Type2")) {
            CuboEmisorV4.OnCollision -= Orientar;
        }
    }

    private void Teletransportar()
    {
        transform.position = objectReference.position;
        transform.rotation = objectReference.rotation;
        Debug.Log($"{name} se ha teletransportado a {objectReference.name}");
    }

    private void Orientar()
    {
         // Apunta hacia el objetivo
        transform.LookAt(objectReference);
        // Opcional: mover ligeramente hacia el objetivo
        transform.position = Vector3.MoveTowards(transform.position, objectReference.position, 1f * Time.deltaTime);
        Debug.Log($"{name} se está orientando hacia {objectReference.name}");
    }
}

