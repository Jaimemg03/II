using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlType1 : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad = 3f;
    private bool mover = false;
    private void OnEnable()
    {
        // Suscribirse al evento del cilindro
        CilindroEmisor.OnCubeCollision += RecibirMensaje;
    }

    private void OnDisable()
    {
        // Cancelar suscripción
        CilindroEmisor.OnCubeCollision -= RecibirMensaje;
    }

    private void RecibirMensaje()
    {
        mover = true;
        Debug.Log($"{name} ha recibido el mensaje del cilindro.");
    }

    private void Update()
    {
        if (!mover) return;
        transform.position = Vector3.MoveTowards(
            transform.position,
            objetivo.position,
            velocidad * Time.deltaTime
        );
    }
}

