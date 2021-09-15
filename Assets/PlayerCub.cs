using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCub : MonoBehaviour
{
    float hor;
    public float speed = 7;
    public float JumpForce = 500;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(hor * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * JumpForce);
        }
    }
}
