using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private float dirX;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        dirX = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, 10f);
        }

        UpdateAnimnationState();
       
    }

    private void UpdateAnimnationState()
    {
        //Move with animation left & right
        if (dirX > 0f)
        {
            anim.SetBool("running", true);
        }
        else if (dirX < 0f)
        {
            anim.SetBool("running", true);
        }
        else
        {
            anim.SetBool("running", false);

        }
    }
}
