using UnityEngine;

public class Collectible : MonoBehaviour
{
    private bool isAttracted = false;
    private Transform target;
    public float attractionSpeed = 5f;

    void Update()
    {
        if (isAttracted && target != null)
        {
            // Mueve el objeto hacia el jugador
            transform.position = Vector3.MoveTowards(
                transform.position,
                target.position,
                attractionSpeed * Time.deltaTime
            );

            // Si llega al jugador, se recolecta
            if (Vector3.Distance(transform.position, target.position) < 0.5f)
            {
                gameObject.SetActive(false);
                Debug.Log("Recolectado: " + gameObject.name);
            }
        }
    }

    public void StartAttraction(Transform player)
    {
        isAttracted = true;
        target = player;
    }
}
