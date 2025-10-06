using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script01 : MonoBehaviour
{
    public int frameCounter = 0; // Contador de frames
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Color color = new Color(0.5f, 0.5f, 0.5f, 1.0f);
        
        // Aplicar color inicial
        CambiarColorAleatorio();
    }

    // Update is called once per frame
    void Update()
    {
        frameCounter++; // Incrementar contador cada frame
        
        // Cada 120 frames, cambiar el color
        if (frameCounter >= 120)
        {
            CambiarColorAleatorio();
            frameCounter = 0; // Reiniciar contador
        }
    }
    
    // Método para cambiar el color del objeto de forma aleatoria
    void CambiarColorAleatorio()
    {
        // Generar valores RGB aleatorios entre 0 y 1
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        
        // Crear color aleatorio
        Color colorAleatorio = new Color(r, g, b, 1.0f);
        
        // Aplicar el color al objeto si tiene un Renderer
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.color = colorAleatorio;
        Debug.Log("Color actualizado en frame " + Time.frameCount + ": " + colorAleatorio);
    }
}
