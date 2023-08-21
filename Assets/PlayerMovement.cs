using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    
    private float dirX;
    private Rigidbody2D rb;
    private Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(dirX * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space)){
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }

        UpdateAnimationState();

    }

    private void UpdateAnimationState()
    {
        if (dirX > 0f){
            anim.SetBool("running",true);
        }
        else if (dirX < 0f){
            anim.SetBool("running",true);
            spriteRenderer.
        }
        else{
            anim.SetBool("running",false);
        }
    }
}
