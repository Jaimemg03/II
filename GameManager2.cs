using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    public static GameManager2 instancia;
    public int puntos = 0;

    private void Awake()
    {
        instancia = this;
    }

    public void SumarPuntos2(int cantidad)
    {
        puntos += cantidad;
        Debug.Log("Puntos: " + puntos);

        if (puntos >= 200)
        {
            AlinearEscudosTipo1();
        }
    }

    void AlinearEscudosTipo1()
    {
        // Buscar el jugador
        GameObject jugador = GameObject.FindGameObjectWithTag("Jugador");
        if (jugador == null) return;

        Vector3 posicionBase = jugador.transform.position + jugador.transform.forward * 2f;

        // Obtener todos los escudos tipo 1
        GameObject[] escudos = GameObject.FindGameObjectsWithTag("EscudoTipo1");

        for (int i = 0; i < escudos.Length; i++)
        {
            GameObject escudo = escudos[i];
            Rigidbody rb = escudo.GetComponent<Rigidbody>();
            if (rb != null)
            {
                // Calculamos desplazamiento lateral para separar escudos
                Vector3 desplazamiento = jugador.transform.right * (i - escudos.Length / 2f);

                // Movemos el escudo a la posición final
                rb.position = posicionBase + desplazamiento;
            }
        }
    }
}
