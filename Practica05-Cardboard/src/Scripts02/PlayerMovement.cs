using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2f;
    // Update is called once per frame
    void Update()
    {
        // Movimiento con teclado o mando (para pruebas)
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        transform.Translate(dir * speed * Time.deltaTime);

        // Movimiento con la vista (Cardboard mira hacia adelante)
        if (Input.GetButton("Fire1")) // botón de Cardboard o pantalla táctil
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
}


