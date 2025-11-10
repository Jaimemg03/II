using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ColorOnSelect : UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable
{
    public Color normalColor = Color.white;
    public Color selectedColor = Color.yellow;
    Renderer rend;

    protected override void Awake()
    {
        base.Awake();
        rend = GetComponent<Renderer>();
        if (rend) rend.material.color = normalColor;
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        if (rend) rend.material.color = selectedColor;
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        if (rend) rend.material.color = normalColor;
    }
}
