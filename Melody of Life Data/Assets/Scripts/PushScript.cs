using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushScript : MonoBehaviour {

    public Rigidbody2D PushObject;
    public static bool Char;
   

    void Start()
    {
      
    }
    // Update is called once per frame
    void Update ()
    {
       

        //if (PushObject.velocity.sqrMagnitude > 0)
        //        {
        //            isMoving = true;
        //        }
        //        else
        //        {
        //            isMoving = false;
        //        }
        //isMovinga = isMoving;
        Char = Gamemanager.WhichChar;

        if (Char == false)
        {
            PushObject.constraints = RigidbodyConstraints2D.FreezePositionX;
        }
        else
        {
            PushObject.constraints = RigidbodyConstraints2D.None;
            PushObject.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        
    }
   // void OnTriggerEnter2D(Collider2D other)
   // {
   //     
   //     if (other.tag == "Enemy" && isMoving == true)
   //     {
   //         Destroy(gameObject);
   //     }
   //     
   // }


}
