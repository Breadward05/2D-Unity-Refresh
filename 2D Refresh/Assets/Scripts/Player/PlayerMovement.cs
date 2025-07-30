using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] InputAction playerControls;

    private Rigidbody2D rb;

    private Vector2 moveDir;

    private Vector2 mousePos;

    [SerializeField] float moveSpeed = 5f;

    [SerializeField] float recoil = -3f;

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        moveDir = playerControls.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveDir.x * moveSpeed, moveDir.y * moveSpeed);
        transform.up = mousePos - new Vector2(transform.position.x, transform.position.y);
        
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            
        }
    }
}
