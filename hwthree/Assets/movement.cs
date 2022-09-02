using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Transform groundPos;
    Rigidbody2D rb;
    public LayerMask groundLayer;
    public float rad;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        bool isGrounded = Physics2D.OverlapCircle(groundPos.position, rad, groundLayer);

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector2(-4, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(4, 0f);
        }
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.velocity = new Vector2(0f, 12);
        }
    }
}
