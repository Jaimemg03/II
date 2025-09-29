using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SciptExample01 : MonoBehaviour
{
  // Start is called before the first frame update
  void Start() {
    GameObject[] allObjects = FindObjectsOfType<GameObject>();

    foreach (GameObject obj in allObjects) {
      if (obj.tag != "Untagged")
      {
          Debug.Log("Name: " + obj.name + 
                    " | Tag: " + obj.tag + 
                    " | Posición: " + obj.transform.position);
      }
    }
  }

  // Update is called once per frame
  void Update()
  {
    
  }
}
