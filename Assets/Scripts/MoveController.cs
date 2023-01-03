using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class MoveController : MonoBehaviour
{
    public UnityEvent<bool> isMoving;
    [SerializeField] private float speed;
    private Rigidbody2D rb2d;
    private Vector2 move;
    private bool canMove = true;
    
    public void DisableMove(bool value)
    {
        canMove = !value;
    }
    
    public void Move(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }
    
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    
    private void FixedUpdate()
    {
        isMoving?.Invoke(move != Vector2.zero && canMove);
        if (!canMove)
            return;
        rb2d.velocity = new Vector2(move.x * speed, rb2d.velocity.y);
    }
}
