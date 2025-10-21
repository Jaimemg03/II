using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlType1V9 : MonoBehaviour
{
    public Transform escudoType2;
    public float velocidad = 3f;
    private bool mover = false;

    public void Start() {
        if (!escudoType2.CompareTag("Type2"))
        {
            Debug.LogError($"El objeto '{escudoType2.name}' no tiene el tag 'Tipo2'. Verifica su configuración.");
        }
    }

    private void OnEnable()
    {
        // Suscribirse al evento del cubo
        CuboEmisorV9.OnType2Collision += RecibirMensaje;
    }

    private void OnDisable()
    {
        // Cancelar suscripción
        CuboEmisorV9.OnType2Collision -= RecibirMensaje;
    }

    private void RecibirMensaje()
    {
        mover = true;
        Debug.Log($"{name} ha recibido el mensaje del cubo.");
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Type1") || collision.gameObject.CompareTag("Type1")) {
            // Tomar todos los renderers del personaje (incluyendo hijos)
            Renderer[] renderers = GetComponentsInChildren<Renderer>();
            foreach (Renderer rend in renderers)
            {
                // Crear un material totalmente nuevo con shader estándar
                Material mat = new Material(Shader.Find("Standard"));

                // Asignar un color aleatorio
                mat.color = new Color(Random.value, Random.value, Random.value);

                // Opcional: asignar un Smoothness o Metallic aleatorio
                mat.SetFloat("_Metallic", Random.value);
                mat.SetFloat("_Glossiness", Random.value);

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
            escudoType2.position,
            velocidad * Time.deltaTime
        );
    }
}

