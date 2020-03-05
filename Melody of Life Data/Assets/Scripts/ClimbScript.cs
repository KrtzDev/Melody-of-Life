using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbScript : MonoBehaviour {

    public BoxCollider2D Leiter;
    public bool Char;
    public Rigidbody2D Character;
    public float Upforce;
    public bool a;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
        Char = Gamemanager.WhichChar;
        if (Input.GetKeyUp(KeyCode.Space)) {

            anim.SetBool("Climbing", false);
        }
	}

    void OnTriggerStay2D (Collider2D other)
    {
        if (Char == false && other.tag == "Climb" && Input.GetKey(KeyCode.Space))
        {
            Character.AddRelativeForce(new Vector2(0,Upforce));
            a = true;
            anim.SetBool("Climbing", true);
        }
        
    }
}
