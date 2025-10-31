using UnityEngine;

public static class GameEvents
{
    // Evento al chocar el cubo con el escudo especial
    public delegate void CubeCollisionHandler(Transform jugador);
    public static event CubeCollisionHandler OnSpecialShieldCollision;

    public static void TriggerSpecialShieldCollision(Transform jugador)
    {
        OnSpecialShieldCollision?.Invoke(jugador);
    }
}
