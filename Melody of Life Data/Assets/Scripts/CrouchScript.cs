using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchScript : MonoBehaviour {

    public bool Char;
    public GameObject Character;
    

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
        Char = Gamemanager.WhichChar;
        if (Char == false && Input.GetKeyDown(KeyCode.LeftShift))
        {
            Character.GetComponent<CapsuleCollider2D>().enabled = false;
            Character.GetComponent<BoxCollider2D>().enabled = true;
            anim.SetBool("Crouching", true);
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift)|| Char == true)
        {
            Character.GetComponent<CapsuleCollider2D>().enabled = true;
            Character.GetComponent<BoxCollider2D>().enabled = false;
            anim.SetBool("Crouching", false);
        }
	}
}
