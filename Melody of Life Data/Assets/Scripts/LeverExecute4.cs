using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverExecute4 : MonoBehaviour {

    public Sprite Sprite1;
    public SpriteRenderer Spriterenderer;
    public GameObject Hans;

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.E) && this.tag == "Schalter3")
        {
            Spriterenderer.sprite = Sprite1;
            Destroy(Hans);
        }
    }
}
