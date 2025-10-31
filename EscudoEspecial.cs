using UnityEngine;

public class EscudoEspecial : MonoBehaviour
{
    private void OnEnable()
    {
        GameEvents.OnSpecialShieldCollision += ActivarEventoEspecial;
    }

    private void OnDisable()
    {
        GameEvents.OnSpecialShieldCollision -= ActivarEventoEspecial;
    }

    public void ActivarEventoEspecial(Transform jugador)
    {
        Debug.Log("Escudo especial activado.");

        GameObject guerrero1 = GameObject.FindGameObjectWithTag("GuerreroTipo1");
        GameObject guerrero2 = GameObject.FindGameObjectWithTag("GuerreroTipo2");

        // Mover escudos tipo 1 hacia su guerrero
        foreach (GameObject escudo1 in GameObject.FindGameObjectsWithTag("EscudoTipo1"))
        {
            EscudoTipo1 script = escudo1.GetComponent<EscudoTipo1>();
            if (script != null && guerrero1 != null)
            {
                script.MoverHacia(guerrero1.transform.position);
            }
        }

        // Mover escudos tipo 2 alejándose de su guerrero
        foreach (GameObject escudo2 in GameObject.FindGameObjectsWithTag("EscudoTipo2"))
        {
            EscudoTipo2 script = escudo2.GetComponent<EscudoTipo2>();
            if (script != null && guerrero2 != null)
            {
                Vector3 direccion = (escudo2.transform.position - guerrero2.transform.position).normalized;
                Vector3 destino = escudo2.transform.position + direccion * 5f;
                script.MoverHacia(destino);
            }
        }

        // Alejar guerrero tipo 2 del jugador
        if (guerrero2 != null)
        {
            GuerreroTipo2 guerreroScript = guerrero2.GetComponent<GuerreroTipo2>();
            if (guerreroScript != null)
            {
                Vector3 nuevaDir = (guerrero2.transform.position - jugador.position).normalized;
                Vector3 destino = guerrero2.transform.position + nuevaDir * 5f;
                guerreroScript.MoverHacia(destino);
            }
        }
    }
}
