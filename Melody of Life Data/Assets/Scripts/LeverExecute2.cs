using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverExecute2 : MonoBehaviour {

    public Sprite Sprite1;
    public SpriteRenderer Spriterenderer;
    public Sprite SpriteRohr;
    public SpriteRenderer SpriterendererRohr;
    public GameObject Teleporter;

    // Update is called once per frame
    void Update () {
		
	}
    void OnTriggerStay2D(Collider2D other)
    {
        if (this.tag == "Schalter1" && other.tag == "Carry")
        {
            Spriterenderer.sprite = Sprite1;
            Teleporter.GetComponent<BoxCollider2D>().enabled = true;
            SpriterendererRohr.sprite = SpriteRohr;
        }
    }
}
