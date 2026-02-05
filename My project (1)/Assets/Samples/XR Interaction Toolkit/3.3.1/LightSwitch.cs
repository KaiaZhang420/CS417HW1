using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public InputActionReference action;  // 绑定 XRI Right Interaction/Select
    private Light lightComp;
    private bool isAltColor = false;

    void Awake()
    {
        lightComp = GetComponent<Light>();
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
        // 电脑测试：按 T 切换
        if (Keyboard.current != null && Keyboard.current.tKey.wasPressedThisFrame)
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
        if (lightComp == null) return;

        isAltColor = !isAltColor;                 // ✅ 取反
        lightComp.color = isAltColor ? Color.blue : Color.white;
    }
}
