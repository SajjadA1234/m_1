using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float jumping = 5.5f;
    private Rigidbody2D rb;
///////////////////
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
///////////////////
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
          {
            Jump();
          }
    }
///////////////////    
    void Jump()
    {
         rb.velocity = Vector2.up * jumping;
    }
///////////////////
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.GameOver();
    }
}