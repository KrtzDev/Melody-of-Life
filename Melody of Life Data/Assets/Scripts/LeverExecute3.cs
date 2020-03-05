using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverExecute3 : MonoBehaviour {

    public Sprite Sprite1;
    public SpriteRenderer Spriterenderer;
    public GameObject Leiter;

    // Update is called once per frame
    void Update () {
       
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.E) && this.tag == "Schalter2")
        {
            Spriterenderer.sprite = Sprite1;
            Leiter.GetComponent<SpriteRenderer>().enabled = true;
            Leiter.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
