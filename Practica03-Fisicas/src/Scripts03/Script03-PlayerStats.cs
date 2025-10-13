using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float damage = 0f;

    public void AddDamage(float amount)
    {
        damage += amount;
        Debug.Log("Daño acumulado: " + damage);
    }
}
