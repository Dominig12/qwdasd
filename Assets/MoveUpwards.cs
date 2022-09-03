using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpwards : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 movevector;
    public float speed = 2f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        walk();
    }

    void walk()
    {
        movevector.y = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(movevector.y * speed, rb.velocity.x);
    }
}