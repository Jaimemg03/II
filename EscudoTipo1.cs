using UnityEngine;

public class EscudoTipo1 : MonoBehaviour
{
    private bool mover = false;
    private Vector3 destino;
    private float velocidad = 3f;

    public void MoverHacia(Vector3 puntoDestino)
    {
        destino = puntoDestino;
        mover = true;
    }

    private void Update()
    {
        if (mover)
        {
            transform.position = Vector3.MoveTowards(transform.position, destino, velocidad * Time.deltaTime);

            if (Vector3.Distance(transform.position, destino) < 0.1f)
            {
                mover = false;
            }
        }
    }
}
