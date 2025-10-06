using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script08 : MonoBehaviour
{
    public float speed;
    public Vector3 moveDirection;
    public char option;
    public bool relativemovement = false;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1.5f;
        moveDirection = new Vector3(1.0f, 0.0f, 0.0f);
        transform.position = new Vector3(transform.position.x, 0.0f, transform.position.z); // Asegura que el objeto empieza en y=0
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = moveDirection.normalized * speed * Time.deltaTime + transform.position;
        switch (option)
        {
            case 'a': // Duplica las coordenadas del vector de movimiento
                moveDirection *= 2;
                break;
            case 'b': // Duplica la velocidad
                speed *= 2;
                break;
            case 'c': // La velocidad es menor que 1
                speed = Random.Range(0.1f, 1.0f);
                break;
            case 'd': // La posicion del cubo tiene y > 0
                transform.position = new Vector3(transform.position.x, Random.Range(0.1f, 5.0f), transform.position.z);
                break;
            case 'e': // Intercambiar el movimiento relativo al sistema de referencia local y global
                if (relativemovement)
                {
                    transform.Translate(moveDirection.normalized * speed * Time.deltaTime, Space.World);
                    relativemovement = false;
                }
                else
                {
                    transform.Translate(moveDirection.normalized * speed * Time.deltaTime, Space.Self);
                    relativemovement = true;
                }
                
                break;
            default:
                Debug.Log("Opción no válida. Usa 'a', 'b', 'c', 'd' o 'e'.");
                break;
        }
    }
}
