using UnityEngine;

public class RecoveryPoint : MonoBehaviour
{
    public float gazeTime = 2f;
    private float timer;
    private bool gazedAt = false;
    public Transform player;

    void Update()
    {
        if (gazedAt)
        {
            timer += Time.deltaTime;
            if (timer >= gazeTime)
            {
                AttractCollectibles();
                timer = 0f;
            }
        }
        else
        {
            timer = 0f;
        }
    }

    public void OnPointerEnter()
    {
        Debug.Log("ME H AMIRADO");
        gazedAt = true;
    }

    public void OnPointerExit()
    {
        gazedAt = false;
    }

    private void AttractCollectibles()
    {
        Debug.Log("Activando atracción hacia el jugador...");
        GameObject[] treasures = GameObject.FindGameObjectsWithTag("Treasure");


        foreach (GameObject treasure in treasures)
        {
            Collectible collectible = treasure.GetComponent<Collectible>();
            if (collectible != null)
            {
                collectible.StartAttraction(player);
            }
        }
    }
}
