using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingQuiz : MonoBehaviour {

    public int Ringe;
    public SpriteRenderer RingfR;
    public SpriteRenderer RingfB;
    public SpriteRenderer RingfY;
    public SpriteRenderer RingR;
    public SpriteRenderer RingB;
    public SpriteRenderer RingY;
    public Sprite Sprite1;
    public Sprite Spritef1;
    public Sprite SpritefR;
    public Sprite SpritefB;
    public Sprite SpritefY;
    public Sprite SpriteR;
    public Sprite SpriteB;
    public Sprite SpriteY;
    public SpriteRenderer Pyramid;
    public Sprite PyramidSprite;
    public GameObject SceneChangelvl2;
   
	
	// Update is called once per frame
	void Update () {
        if (Ringe == 3)
        {
            Pyramid.sprite = PyramidSprite;
            SceneChangelvl2.GetComponent<BoxCollider2D>().enabled = true;
        }
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "RingB" && Ringe == 0)
        {
            Ringe = 1;
            RingB.sprite = Sprite1;
            RingfB.sprite = Spritef1;
        }
        else if (other.tag =="RingB" && Ringe != 0)
        {
            Ringe = 0;
            RingB.sprite = SpriteB;
            RingfB.sprite = SpritefB;
        }
        if (other.tag == "RingY" && Ringe == 1)
        {
            Ringe = 2;
            RingY.sprite = Sprite1;
            RingfY.sprite = Spritef1;
        }
        else if (other.tag == "RingY" && Ringe != 1) 
        {
            Ringe = 0;
            RingY.sprite = SpriteY;
            RingfY.sprite = SpritefY;
        }
        if (other.tag == "RingR" && Ringe == 2)
        {
            Ringe = 3;
            RingR.sprite = Sprite1;
            RingfR.sprite = Spritef1;
        }
        else if(other.tag == "RingR" && Ringe != 2)
        {
            Ringe = 0;
            RingR.sprite = SpriteR;
            RingfR.sprite = SpritefR;
        }
        
    }
}
