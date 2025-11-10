using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LogOnGrab : UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable
{
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        Debug.Log($"{gameObject.name} ha sido agarrado.");
    }
}
