using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverExecute1 : MonoBehaviour {

    public Sprite Sprite1;
    public SpriteRenderer Spriterenderer;
    public SpriteRenderer SpriterendererBaum;
    public Sprite SpriteBaum;
    public GameObject Teleporter;
    // Update is called once per frame
    void Update () {
		
	}
    void OnTriggerStay2D(Collider2D other)
    {
        if (LeverBuild.SchalterC == true && Input.GetKeyDown(KeyCode.E) && this.tag == "SchalterKlotz")
        {
            Debug.Log("gedruekt");
            Spriterenderer.sprite = Sprite1;
            Teleporter.GetComponent<BoxCollider2D>().enabled = true;
            SpriterendererBaum.sprite = SpriteBaum;
        }
    }
   
}
