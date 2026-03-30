using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [Header("Réglages")]
    public float playerSpeed = 5.0f;
    public float mouseSensitivity = 20.0f;

    [Header("Configuration Input")]
    public InputActionAsset moveAction;

    private CharacterController controller;
    private float xRotation = 0f; 

    void Awake()
    {
        controller = GetComponent<CharacterController>();
        
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnEnable()
    {
        moveAction.Enable();
    }

    private void OnDisable()
    {
        moveAction.Disable();
    }

    void Update()
    {
        Vector2 input = moveAction.FindAction("MoveAction").ReadValue<Vector2>();
        
        Vector3 moveRelative = transform.forward * input.y + transform.right * input.x;
        moveRelative.y = 0; // On empêche de s'envoler
        controller.Move(moveRelative * playerSpeed * Time.deltaTime);

        Vector2 lookInput = moveAction.FindAction("LookAction").ReadValue<Vector2>();

        float mouseX = lookInput.x * mouseSensitivity * Time.deltaTime;
        float mouseY = lookInput.y * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, transform.localRotation.eulerAngles.y + mouseX, 0);

        if (Keyboard.current.zKey.wasPressedThisFrame)
        {
            Debug.Log("Touche Z pressée !");
        }
    }
}