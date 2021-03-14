using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    
    private bool jumpPressed;

    [HideInInspector] public Player player;

    private bool isGrounded;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float checkRadious;
    [SerializeField] private LayerMask whatIsGround;

    [SerializeField] private float speed = 5;
    [SerializeField] private float jumpForce;

    private float jumpTimeCounter;
    [SerializeField] private float jumpTime;
    private bool isJumping;

    private float moveInput;
    private Rigidbody2D rb;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    

    private void Update()
    {
        if (jumpPressed && isJumping)
        {
            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadious, whatIsGround);
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    public void JumpStart()
    {
        jumpPressed = true;
        if (isGrounded)
        {
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    public void JumpEnd()
    {
        jumpPressed = false;
        isJumping = false;
    }

    public void Movement(float input)
    {
        moveInput = input;
    }
}
