using UnityEngine;
using UnityEngine.InputSystem;

public class QuitAction : MonoBehaviour
{
    public InputActionReference action;

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
        // 电脑/模拟器兜底：ESC 退出 Play（Build 里退出程序）
        if (Keyboard.current != null && Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            QuitNow();
        }
    }

    void OnPerformed(InputAction.CallbackContext ctx) => QuitNow();

    void QuitNow()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
