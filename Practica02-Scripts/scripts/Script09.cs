using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script09 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1.1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!(CompareTag("cubo") || CompareTag("esfera")))
            return; // Si no es cubo ni esfera, no hace nada

        Vector3 movimiento = Vector3.zero;

        if (CompareTag("cubo") && (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)))
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            movimiento = new Vector3(horizontal, 0, vertical);
        }
        else if (CompareTag("esfera") && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)))
        {
            float horizontal = 0f, vertical = 0f;
            if (Input.GetKey(KeyCode.A)) horizontal = -1f;
            if (Input.GetKey(KeyCode.D)) horizontal = 1f;
            if (Input.GetKey(KeyCode.W)) vertical = 1f;
            if (Input.GetKey(KeyCode.S)) vertical = -1f;
            movimiento = new Vector3(horizontal, 0, vertical);
        }

        transform.Translate(movimiento * speed, Space.World);
    }
}
