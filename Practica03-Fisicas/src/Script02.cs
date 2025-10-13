using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script02 : MonoBehaviour
{
    private Renderer rend;
    public Color originalColor;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name + " colisionó con " + collision.gameObject.name);
        rend.material.color = Random.ColorHSV();
    }

    void OnCollisionExit(Collision collision)
    {
        rend.material.color = originalColor;
    }
}
