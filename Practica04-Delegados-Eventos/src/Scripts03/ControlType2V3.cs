using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlType2V3 : MonoBehaviour
{
    public Transform escudo;      // Referencia al escudo seleccionado
    public float velocidad = 3f;
    private bool mover = false;
    private void OnEnable()
    {
        // Suscribirse al evento del cubo
        CuboEmisor.OnType1Collision += RecibirMensaje;
    }

    private void OnDisable()
    {
        // Cancelar suscripción
        CuboEmisor.OnType1Collision -= RecibirMensaje;
    }

    private void RecibirMensaje()
    {
        mover = true;
        Debug.Log($"{name} ha recibido el mensaje del cubo.");
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Type1") || collision.gameObject.CompareTag("Type2")) {
            // Tomar todos los renderers del personaje (incluyendo hijos)
            Renderer[] renderers = GetComponentsInChildren<Renderer>();
            foreach (Renderer rend in renderers)
            {
                // Crear un material totalmente nuevo con shader estándar
                Material mat = new Material(Shader.Find("Standard"));
                // Asignar un color aleatorio
                mat.color = new Color(Random.value, Random.value, Random.value);
                // Aplicar el material al renderer
                rend.material = mat;
            }
        }
    }

    private void Update()
    {
        if (!mover) return;
        transform.position = Vector3.MoveTowards(
            transform.position,
            escudo.position,
            velocidad * Time.deltaTime
        );
    }
}

