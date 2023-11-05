using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 7f;
    public float Move = 40f;

    void Update()
    {
        Rigidbody2D rb;
        rb = GetComponent<Rigidbody2D>();

        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(Move * speed, rb.velocity.y);
    }
}
