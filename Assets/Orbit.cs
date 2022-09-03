using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public float angle = 0; // „…„s„€„| 
    public float radius = 0.5f; // „‚„p„t„y„…„ƒ
    public bool isCircle = false; // „…„ƒ„|„€„r„y„u „t„r„y„w„u„~„y„‘ „„€ „{„‚„…„s„…
    public float speed = 4f;
    public Rigidbody2D rb;
    public Vector2 movevector;
    public string lastkey;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isCircle)
        {
            if (Input.GetKey(KeyCode.A) & lastkey == "R") 
            {
                transform.position = new Vector2(Mathf.Cos(angle * speed * (-1) * movevector.x) * radius, Mathf.Sin(angle * speed * (-1) * movevector.x) * radius) + new Vector2(transform.localPosition.x, transform.localPosition.y);
            }
                if (Input.GetKey(KeyCode.A)) { movevector.x = 1; lastkey = "L"; }
            if (Input.GetKey(KeyCode.D)) { movevector.x = -1; lastkey = "R"; }
                var x = Mathf.Cos(angle * speed * movevector.x) * radius;
                var y = Mathf.Sin(angle * speed * movevector.x) * radius;
            if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) movevector.x = 0;
            if (movevector.x != 0) 
            { 
                transform.position = new Vector2(x, y) + new Vector2(transform.localPosition.x, transform.localPosition.y); 
            }
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) angle += Time.deltaTime; // „}„u„~„‘„u„„„ƒ„‘ „„|„p„r„~„€ „x„~„p„‰„u„~„y„u „…„s„|„p
        }
    } 
}