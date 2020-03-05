using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwimmingScript : MonoBehaviour {

    public Rigidbody2D Character;
    public float Upforce;

    public bool Swimming;
    public Transform groundCheck;
    public float groundRadius = 0.2f;
    public LayerMask whatIsGround;

    Animator anim;

    // Update is called once per frame
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update () {
        Swimming = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        if (Swimming == true)
        {
            anim.SetBool("Swimming", true);
        }
        else if (Swimming == false)
        {
            anim.SetBool("Swimming", false);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Water" && Input.GetKey(KeyCode.Space))
        {
            Character.AddRelativeForce(new Vector2(0, Upforce));
        }

    }
}
