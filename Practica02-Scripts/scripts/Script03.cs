using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script03 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var t = GetComponent<Transform>();
        Debug.Log("La posición de la esfera es:" + t.position);
    }
}
