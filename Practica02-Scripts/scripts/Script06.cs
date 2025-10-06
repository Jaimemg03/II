using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script06 : MonoBehaviour
{
    public float velocidad = 10f;

    void Update()
    {
        // Detectar teclas flecha y mostrar cálculo en consola
        if (Input.GetKey(KeyCode.UpArrow))
        {
            float resultado = velocidad * Input.GetAxis("Vertical");
            Debug.Log("Flecha Arriba: " + resultado);
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            float resultado = velocidad * Input.GetAxis("Vertical");
            Debug.Log("Flecha Abajo: " + resultado);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            float resultado = velocidad * Input.GetAxis("Horizontal");
            Debug.Log("Flecha Izquierda: " + resultado);
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            float resultado = velocidad * Input.GetAxis("Horizontal");
            Debug.Log("Flecha Derecha: " + resultado);
        }
    }
}
