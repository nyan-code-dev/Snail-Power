using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    
    private bool jumpPressed;

    [HideInInspector] public Player player;

    [HideInInspector] public bool isGrounded;
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
    private Animator anim;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
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
        anim.SetBool("Running", !Mathf.Approximately(moveInput, 0));
        if (moveInput >= -0.5f)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        else if (moveInput <= 0.5f)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x) * -1, transform.localScale.y, transform.localScale.z);
        }
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadious, whatIsGround);
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    public void JumpStart()
    {
        if (!player.canMove)
            return;

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
        if (!player.canMove)
            return;

        jumpPressed = false;
        isJumping = false;
    }

    public void Movement(float input)
    {
        if (!player.canMove)
            return;
        moveInput = input;
    }
}
