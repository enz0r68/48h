using UnityEngine;
using UnityEngine.InputSystem;

public class mouseDirection : MonoBehaviour
{
    [Header("Réglages")]
    public float mouseSensitivity = 20.0f;
    public InputActionAsset lookAction;
    public Transform playerBody;

    private float xRotation = 0f;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;

        if (playerBody == null && transform.parent != null)
        {
            playerBody = transform.parent;
        }

        if (lookAction == null)
        {
            Movement parentMovement = GetComponentInParent<Movement>();
            if (parentMovement != null)
            {
                lookAction = parentMovement.moveAction;
            }
        }
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
        if (lookAction == null || playerBody == null)
            return;

        Vector2 lookInput = lookAction.FindAction("LookAction").ReadValue<Vector2>();

        float mouseX = lookInput.x * mouseSensitivity * Time.deltaTime;
        float mouseY = lookInput.y * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        playerBody.Rotate(Vector3.up * mouseX);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}