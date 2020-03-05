using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacter : MonoBehaviour {

	public static bool Character = true;
    public Sprite sprite1;
    public Sprite sprite2;
    public SpriteRenderer spriteRenderer;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update ()

    {
        //Character wechsel
        if (Input.GetKeyDown("c"))
        {
            if (Character == true)
            {
                Character = false;
                anim.SetBool("Char", false);
            }
            else if (Character == false)
            {
                Character = true;
                anim.SetBool("Char", true);
            }
                
            print(Character);


            //Wechsel auf Inki
            if (Character == true)
            {
                spriteRenderer.sprite = sprite1;
            }
            //Wechsel auf Pale
            if (Character == false)
            {
                spriteRenderer.sprite = sprite2;
            }
        }
        
    }
}
