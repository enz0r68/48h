using UnityEngine;
using UnityEngine.InputSystem;

public class mouseDirection : MonoBehaviour
{
    [Header("Réglages")]
    public float mouseSensitivity = 20.0f;
    public InputActionAsset lookAction;

    private float xRotation = 0f;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnEnable()
    {
        lookAction?.Enable();
    }

    private void OnDisable()
    {
        lookAction?.Disable();
    }

    void Update()
    {
        if (lookAction == null)
            return;

        Vector2 lookInput = lookAction.FindAction("LookAction").ReadValue<Vector2>();

        float mouseX = lookInput.x * mouseSensitivity * Time.deltaTime;
        float mouseY = lookInput.y * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, transform.localRotation.eulerAngles.y + mouseX, 0);
    }
}