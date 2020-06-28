using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody2D rb;
    private float powerForce = 7f; // сила толчка 
    Vector3 direction = Vector3.zero;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce((Vector3.up + direction) * powerForce, ForceMode2D.Impulse);
        }

    }

    void Update()
    {
        //Debug.Log(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            direction.x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x/2;
            
            gameObject.GetComponent<Rigidbody2D>().AddForce(direction * powerForce, ForceMode2D.Impulse);


        }
    }
}
