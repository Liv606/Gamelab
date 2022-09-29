using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float jumpForce = 10f;                  //altura máxima que vai conseguir pular
    public Rigidbody2D rb;                         //cria um rigbody para colocar no player


    // Update is called once per frame
    void Update() {


        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {

            rb.velocity = Vector2.up * jumpForce;                                                  //assim a velocidade dele não compete com a de queda

        }

    }

    void OnTriggerEnter2D (Collider2D col)                                           //registra sempre que colidir com alguma coisa
    {

        Debug.Log(col.tag);

    }

}