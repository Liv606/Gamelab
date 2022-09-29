using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float playerSpeed = 0.5f;

    Vector2 movimento;

    // Update is called once per frame
    void Update()
    {

        movimento.x = Input.GetAxisRaw("Horizontal");
        movimento.y = Input.GetAxisRaw("Vertical");

    }

    void FixedUpdate()
    {
        
        rb.MovePosition(rb.position + movimento * playerSpeed * Time.unscaledDeltaTime);

    }

}
