using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float maxSpeed ;
    public bool facingRight = true;
    public Rigidbody2D Character;
    public float move;
    public float delay;
   

    Animator anim;
    // Use this for initialization
    void Start ()
    {

        move = -1;
        anim = GetComponent<Animator>();
       
    }
	
	// Update is called once per frame
	void Update ()
    {
        Character.velocity = new Vector2(move * maxSpeed, Character.velocity.y);
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Grenze")
        {
            Flip();
            move = -1;
        }
        if(other.tag == "Grenze1")
        {
            Flip();
            move = 1;
        }
        if (other.tag == "Carry" )
        {
            move = 0;
            anim.SetBool("Dead", true);
            this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            Destroy(gameObject,delay);
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
