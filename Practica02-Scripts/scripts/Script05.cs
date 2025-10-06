using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script05 : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 desplazamiento;
    public Vector3 posicionOrigen;
    void Start()
    {
        posicionOrigen = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float espacio = Input.GetAxis("Jump");

        if (espacio > 0)
        {
            transform.position = posicionOrigen + desplazamiento;
            posicionOrigen = transform.position;
        }
    }
}
