using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script05 : MonoBehaviour
{
    public float forceAmount = 500f;
    public ForceMode forceMode = ForceMode.Force;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            ApplyForceForward();
        }
    }

    void ApplyForceForward()
    {
        if (rb == null) return;
        // Aplicar fuerza en el eje local Z del objeto
        Vector3 direction = transform.forward; // eje Z local
        rb.AddForce(direction * forceAmount, forceMode);
        Debug.Log($"{gameObject.name}: AddForce aplicado en dirección {direction} con magnitud {forceAmount}.");
    }
}
