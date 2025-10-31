using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instancia;

    public int puntos = 0;
    public bool bonificacionActiva = false;

    private void Awake()
    {
        instancia = this;
    }

    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;
        Debug.Log("Puntos: " + puntos);

        if (puntos >= 100 && !bonificacionActiva)
        {
            bonificacionActiva = true;
            AumentarEfectosEscudos();
        }
    }

    void AumentarEfectosEscudos()
    {
        // Duplicar recompensa de EscudosTipo1 (ya se controla desde EscudoTipo1)
        // Aumentar tamaño de los EscudosTipo2
        foreach (GameObject escudo in GameObject.FindGameObjectsWithTag("EscudoTipo2"))
        {
            escudo.transform.localScale *= 1.5f;
        }

        Debug.Log("¡Bonificación activada! EscudosTipo2 aumentan de tamaño.");
    }
}
