 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float rychlost =2f;
    private Animator animator;
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       HraceInput();
       animator.SetBool("Chodi", movement != Vector2.zero);
    }

    void FixedUpdate()
    {
        Pohyb();
    }
    private void HraceInput()
    {
        movement = Vector2.zero;
        if(Input.GetKey(KeyCode.W))
        {
            movement.y = 1;
            animator.SetInteger("Smer", 0);
        }
/*else*/if(Input.GetKey(KeyCode.S))
        {
            movement.y = -1;
            animator.SetInteger("Smer", 2);
        }
/*else*/if (Input.GetKey(KeyCode.D))
        {
            movement.x = 1;
            animator.SetInteger("Smer", 1);
        }
/*else*/if (Input.GetKey(KeyCode.A))
        {
            movement.x = -1;
            animator.SetInteger("Smer", 3);
        }
    /**/movement = movement.normalized;
    }
    private void Pohyb()
    {
        Vector2 novaPozice = rb.position + movement * rychlost * Time.fixedDeltaTime;
        rb.MovePosition(novaPozice);
    }
}
