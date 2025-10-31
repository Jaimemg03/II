using UnityEngine;

public class JugadorController : MonoBehaviour
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
            int puntos = GameManager.instancia.bonificacionActiva ? 20 : 10;
            GameManager.instancia.SumarPuntos(puntos);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("EscudoTipo2"))
        {
            Debug.Log("Colision con el escudo Tipo2");
            GameManager.instancia.SumarPuntos(20);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("EscudoEspecial"))
        {
            Debug.Log("Escudo especial alcanzado: Evento lanzado");
            GameEvents.TriggerSpecialShieldCollision(transform);
            Destroy(other.gameObject);
        }
    }
}
