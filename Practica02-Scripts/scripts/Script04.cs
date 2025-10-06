using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script04 : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject elcilindro;
    GameObject elcubo;
    void Start()
    {
        elcilindro = GameObject.FindWithTag("cilindro");
        elcubo = GameObject.FindWithTag("cubo");
        if (elcilindro == null)
        {
            Debug.LogWarning("No se encontró el cilindro con tag 'cilindro'");
        }
        if (elcubo == null)
        {
            Debug.LogWarning("No se encontró el cubo con tag 'cubo'");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Distancia al Cubo:" + Vector3.Distance(transform.position, elcubo.transform.position) +
                  "| Distancia al Cilindro:" + Vector3.Distance(transform.position, elcilindro.transform.position));
    }
}
