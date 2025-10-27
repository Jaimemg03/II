using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float gazeTime = 2f;  // segundos mirando para recoger
    private float timer;
    private bool gazedAt;

    void Start()
    {
        timer = 0f;
        gazedAt = false;
    }

    void Update()
    {
        if (gazedAt)
        {
            timer += Time.deltaTime;
            if (timer >= gazeTime)
            {
                Collect();
            }
        }
        else
        {
            timer = 0f;
        }
    }
        public void OnPointerEnter()
    {
        gazedAt = true;
    }

    public void OnPointerExit()
    {
        gazedAt = false;
    }

    void Collect()
    {
        // Desactiva el objeto o añade puntos
        gameObject.SetActive(false);
        Debug.Log("Objeto recolectado: " + gameObject.name);
    }
}
