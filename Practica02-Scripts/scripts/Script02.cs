using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script02 : MonoBehaviour
{
    public Vector3 vector1 = new Vector3(0.0f, 1.0f, 0.0f);
    public Vector3 vector2 = new Vector3(0.0f, 1.0f, 0.0f);
    void Start()
    {
        // Los vectores ahora son campos públicos (visibles en el Inspector)
        Debug.Log("Vector1: " + vector1 + " Vector2: " + vector2);
        Debug.Log("Magnitud del vector1: " + vector1.magnitude + " Magnitud del vector2: " + vector2.magnitude);
        Debug.Log("Angulo entre los vectores: " + Vector3.Angle(vector1, vector2));
        Debug.Log("Distancia entre los vectores: " + Vector3.Distance(vector1, vector2));
        // Comprobar que vector esta a una mayor altura
        if (vector1.y > vector2.y) {
            Debug.Log("Vector1 esta a mayor altura que Vector2");
        }
        else if (vector1.y < vector2.y) {
            Debug.Log("Vector2 esta a mayor altura que Vector1");
        }
        else {
            Debug.Log("Vector1 y Vector2 estan a la misma altura");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
