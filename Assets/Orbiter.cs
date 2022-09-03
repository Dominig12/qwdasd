using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Orbiter : MonoBehaviour
{
    public float angle = 0; // „…„s„€„| 
    public float radius = 0.5f; // „‚„p„t„y„…„ƒ
    public bool isCircle = false; // „…„ƒ„|„€„r„y„u „t„r„y„w„u„~„y„‘ „„€ „{„‚„…„s„…
    public float speed = 0.5f;
    public Rigidbody2D rb;
    public Vector2 movevector;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isCircle)
        {
            if (Input.GetKeyDown(KeyCode.A)) speed = Math.Abs(speed);
            if (Input.GetKeyDown(KeyCode.D)) speed = (-1) * Math.Abs(speed);
                angle += Time.deltaTime; // „}„u„~„‘„u„„„ƒ„‘ „„|„p„r„~„€ „x„~„p„‰„u„~„y„u „…„s„|„p

            var x = Mathf.Cos(angle * speed) * radius;
            var y = Mathf.Sin(angle * speed) * radius;
            transform.localPosition = new Vector2(x, y) + new Vector2(1, 1.5f);
        }
    }
}
