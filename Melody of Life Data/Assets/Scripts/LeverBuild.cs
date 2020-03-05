using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverBuild : MonoBehaviour {

    public Sprite Sprite1;
    public SpriteRenderer Spriterenderer;
    public bool SchalterComplete;
    public static bool SchalterC;
	
	// Update is called once per frame
	void Update () {
        SchalterC = SchalterComplete;
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.E) && this.tag =="SchalterKlotz" && CarryScript.CS == true)
        {
            Spriterenderer.sprite = Sprite1;
            SchalterComplete = true;
            Destroy(CarryScript.CO);
        }
    }
}
