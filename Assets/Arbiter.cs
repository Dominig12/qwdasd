using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arbiter : MonoBehaviour
{
    public float angle = 0; // „…„s„€„| 
    public float radius = 0.5f; // „‚„p„t„y„…„ƒ
    public bool isCircle = false; // „…„ƒ„|„€„r„y„u „t„r„y„w„u„~„y„‘ „„€ „{„‚„…„s„…
    public Vector2 movevector;
    public Rigidbody2D rb;
    public float speed = 4f;
    public float xcord;
    public float ycord;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    { if (Input.GetKeyDown(KeyCode.Q) & isCircle == false)
        {
            xcord = transform.position.x;
            ycord = transform.position.y;
            transform.position = new Vector2(xcord, ycord);
            isCircle = true;
            return;
        } if (Input.GetKeyDown(KeyCode.Q) & isCircle == true)
        {
            isCircle = false;
            movevector.x = 0;
            angle = 0;
            return;
        }
        if (isCircle == true)
        {
            if (Input.GetKeyDown(KeyCode.A)) movevector.x = 1;
            if (Input.GetKeyDown(KeyCode.D)) movevector.x = -1;
            if (movevector.x == 0) { angle = 0; }
            var x = Mathf.Cos(movevector.x * angle * speed) * radius;
            var y = Mathf.Sin(angle * speed) * radius;
            if (movevector.x != 0)
            {
                transform.position = new Vector2(x, y); 
            }
            angle += Time.deltaTime; // „}„u„~„‘„u„„„ƒ„‘ „„|„p„r„~„€ „x„~„p„‰„u„~„y„u „…„s„|„p
        }
    }
}