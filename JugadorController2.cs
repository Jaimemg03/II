using UnityEngine;

public class JugadorController2 : MonoBehaviour
{
    public float velocidad = 5f;

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h, 0, v) * velocidad * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EscudoTipo1"))
        {
            Debug.Log("Colision con el escudo Tipo1");
            if (GameManager2.instancia != null)
                GameManager2.instancia.SumarPuntos2(100);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("EscudoTipo2"))
        {
            Debug.Log("Colision con el escudo Tipo2");
            if (GameManager2.instancia != null)
                GameManager2.instancia.SumarPuntos2(200);
            Destroy(other.gameObject);
        }
    }
}
