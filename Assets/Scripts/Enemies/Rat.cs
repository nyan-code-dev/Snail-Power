using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rat : MonoBehaviour
{
    private bool facingRight;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Mathf.Abs(rb.velocity.x) < 0.01f)
        {
            facingRight = !facingRight;
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
        if (facingRight)
        {
            rb.velocity = new Vector2(3, 0);
        }
        else
        {
            rb.velocity = new Vector2(-3, 0);
        }
    }
}
