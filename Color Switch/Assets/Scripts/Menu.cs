using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

    public float cair = 10f;
    public Rigidbody2D rbmenu;

    // Update is called once per frame
    void Update()
    {

        rbmenu.velocity = Vector2.down;

    }
}
