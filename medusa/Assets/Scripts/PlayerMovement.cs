using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed = 4f;
    public Rigidbody2D rb;
    Vector2 movement;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update() 
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        setAnimation();
    }

    void setAnimation()
    {
        if (movement != Vector2.zero)
        {
            anim.SetFloat("MoveX", movement.x);
            anim.SetFloat("MoveY", movement.y);
            anim.SetBool("Moving", true);
        }
        else
        {
            anim.SetBool("Moving", false);
        }
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
