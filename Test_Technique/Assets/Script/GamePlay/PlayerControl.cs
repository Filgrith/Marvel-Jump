using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class PlayerControl : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;
    private PlayerInput playerInput;
    private PlayerController playerController;

    private bool isJumping = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();

        playerController = new PlayerController();
        playerController.Enable();
        playerController.Player.Jump.performed += Jump;
    }

    private void FixedUpdate()
    {
        Vector2 inputVector = playerController.Player.Mouvement.ReadValue<Vector2>();
        rb.AddForce(new Vector3(inputVector.x, 0 , inputVector.y) * speed, ForceMode.Force);
    }

    public void Jump(CallbackContext type)
    {
        if (isJumping)
            return;
        if(type.performed && rb != null)
        {
            isJumping = true;
            rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
    }

    public void OnCollisionEnter(Collision collision) => isJumping = false;
    
}
