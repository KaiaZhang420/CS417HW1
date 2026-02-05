using UnityEngine;
using UnityEngine.InputSystem;

public class BreakOutTeleport : MonoBehaviour
{
    public Transform xrOrigin;     // XR Origin (VR)
    public Transform insidePoint;  // InsidePoint
    public Transform outsidePoint; // OutsidePoint

    // VR controller button (bind to XRI Left Interaction/Activate)
    public InputActionReference action;

    private bool isOutside;

    void Start()
    {
        // Start inside (per assignment)
        TeleportTo(insidePoint);
        isOutside = false;
    }

    void OnEnable()
    {
        if (action != null && action.action != null)
        {
            action.action.performed += OnPerformed;
            action.action.Enable();
        }
    }

    void OnDisable()
    {
        if (action != null && action.action != null)
        {
            action.action.performed -= OnPerformed;
            action.action.Disable();
        }
    }

    void Update()
    {
        // Keyboard test: press B to toggle (for desktop / simulator testing)
        if (Keyboard.current != null && Keyboard.current.bKey.wasPressedThisFrame)
        {
            Toggle();
        }
    }

    void OnPerformed(InputAction.CallbackContext ctx)
    {
        Toggle();
    }

    void Toggle()
    {
        isOutside = !isOutside;
        TeleportTo(isOutside ? outsidePoint : insidePoint);
    }

    void TeleportTo(Transform target)
    {
        if (xrOrigin == null || target == null) return;

        // Only move/rotate the XR Origin
        xrOrigin.position = target.position;
        xrOrigin.rotation = target.rotation;
    }
}
