using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movement : MonoBehaviour { public float speed = 7f; public float MoveX; public float MoveY; void Update() { Rigidbody2D rb; rb = GetComponent<Rigidbody2D>(); MoveX = Input.GetAxis("Horizontal"); MoveY = Input.GetAxis("Vertical"); rb.velocity = new Vector2(MoveX * speed, MoveY * speed); } }

//Написать @Taksisha

