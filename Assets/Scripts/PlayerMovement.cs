using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    
    private float dirX;
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider2D;

    [SerializeField] private LayerMask jumpableGround;

    private enum MovementState {idle, running, jumping, falling};
    private MovementState movementState;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(dirX * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded()){
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }

        UpdateAnimationState();

    }

    private void UpdateAnimationState()
    {
        MovementState state;

        if (dirX > 0f){
            state = MovementState.running;
            spriteRenderer.flipX = false;
        }
        else if (dirX < 0f){
            state = MovementState.running;
            spriteRenderer.flipX = true; 
        }
        else {
            state = MovementState.idle;
        }

        if (rb.velocity.y > .1f) 
        {
            state = MovementState.jumping;
        }
        else if (rb.velocity.y < -.1f) 
        {
            state = MovementState.falling;
        }

        anim.SetInteger("movementState", (int)state);
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(boxCollider2D.bounds.center,boxCollider2D.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
