using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    private float maxFallSpeed = 20f;

    private float _horizontalMovement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector2(_horizontalMovement * moveSpeed, 
        Mathf.Clamp(rb.linearVelocityY, -maxFallSpeed, maxFallSpeed));
    }

    public void Move(InputAction.CallbackContext context)
    {
        _horizontalMovement = context.ReadValue<Vector2>().x;
        
    }
}
