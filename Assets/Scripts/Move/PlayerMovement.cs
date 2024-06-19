using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        //movement and animation logic
        movement = new Vector2(horizontalMove, verticalMove) * speed;

        //Flipping logic
        if (horizontalMove > 0 && spriteRenderer.flipX)
        {
            spriteRenderer.flipX = false;
        }
        else if (horizontalMove < 0 && !spriteRenderer.flipX)
        {
            spriteRenderer.flipX = true;
        }

        if (horizontalMove != 0 || verticalMove != 0)
        {
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
    }

    void FixedUpdate()
    {
        //move the character
        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
    }
}
