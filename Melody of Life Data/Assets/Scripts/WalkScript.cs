using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkScript : MonoBehaviour {

    public float maxSpeed = 10f;
    public bool facingRight = true;
    public static bool facingDirection = true;
    public Rigidbody2D Character;

    public bool grounded = false;
    public Transform groundCheck;
    public float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    public float jumpForce = 700f;
    public static bool Char;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        Char = Gamemanager.WhichChar;

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
    
        float move = Input.GetAxis("Horizontal");

        anim.SetFloat("Speed", Mathf.Abs(move));

        Character.velocity = new Vector2(move * maxSpeed, Character.velocity.y);

        if (move > 0 && !facingRight)
        {
            Flip();
            facingDirection = true;
        }
        else if (move < 0 && facingRight)
        {
            Flip();
            facingDirection = false;
        }
        if (Char == true)
        {
            Jump();
        }
        if (grounded == true)
        {
            anim.SetBool("Grounded", true);
        }
        else if (grounded == false)
        {
            anim.SetBool("Grounded", false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Carry")
        {
            anim.SetBool("Pushing", true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Carry")
        {
            anim.SetBool("Pushing",false);
        }
    }

    void Jump()
    {
        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            Character.AddForce(new Vector2(0, jumpForce));
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 TheScale = transform.localScale;
        TheScale.x *= -1;
        transform.localScale = TheScale;
    }
}