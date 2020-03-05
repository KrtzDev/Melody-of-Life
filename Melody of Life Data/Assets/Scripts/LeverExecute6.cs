using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverExecute6 : MonoBehaviour {

    public Sprite Sprite1;
    public SpriteRenderer Spriterenderer;
    public Animator anim;


    void OnTriggerStay2D(Collider2D other)
    {
        if (this.tag == "Schalter5" && Input.GetKeyDown(KeyCode.E) && other.tag =="Player")
        {
            Spriterenderer.sprite = Sprite1;
            anim.SetBool("Lever3u4", true);
        }
    }
}
