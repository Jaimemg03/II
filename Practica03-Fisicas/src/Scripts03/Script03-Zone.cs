using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public enum ZoneType { ColorChange, DamageZone }
    public ZoneType zoneType;
    public Color zoneColor = Color.red;
    public float damageAmount = 10f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (zoneType == ZoneType.ColorChange)
                other.GetComponent<Renderer>().material.color = zoneColor;

            if (zoneType == ZoneType.DamageZone)
                other.GetComponent<PlayerStats>().AddDamage(damageAmount);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && zoneType == ZoneType.ColorChange)
            other.GetComponent<Renderer>().material.color = Color.white;
    }
}