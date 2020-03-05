using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarryScript : MonoBehaviour {

    
    public GameObject CarryedObject;
    public Rigidbody2D CarreydObjectRig;
    public Transform CarryObject;
    public bool Char;
    public bool carrying;
    public bool carryingSchalter;
    public static bool CS;
    public static GameObject CO;


    
    // Update is called once per frame
    
    void Update()
    {
        Char = Gamemanager.WhichChar;
        CS = carryingSchalter;
        CO = CarryedObject;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (Char == true && Input.GetKeyDown(KeyCode.E) && carrying == false && other.tag == "Carry" || Char == true && Input.GetKeyDown(KeyCode.E) && carrying == false && other.tag == "Schalter")
        {
            other.transform.position = CarryObject.transform.position;
            other.transform.parent = CarryObject.transform;
            other.attachedRigidbody.simulated = false;
            carrying = true;
            CarryedObject = other.gameObject;
            CarreydObjectRig = other.GetComponent<Rigidbody2D>();
            if (other.tag == "Schalter")
            {
                carryingSchalter = true;
            }
            
        }
    }

    void FixedUpdate()
    { 
        if (carrying == true && Input.GetKeyDown(KeyCode.E) || Char == false)
        {
            if (CarryedObject == null && CarreydObjectRig == null)
            {
                
            }
            else
            {
                CarryedObject.gameObject.transform.parent = null;
                CarreydObjectRig.GetComponent<Rigidbody2D>().simulated = true;
                carrying = false;
                carryingSchalter = false;
            }
        }
    }
    

}
