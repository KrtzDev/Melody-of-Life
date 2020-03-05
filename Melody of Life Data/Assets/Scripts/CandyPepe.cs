using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CandyPepe : MonoBehaviour {

    public bool Candy;
    public SpriteRenderer SpriteRenderer;
    public Sprite Sprite;
    public SpriteRenderer SpriteRendererBaum;
    public Sprite SpriteBaum;
    public GameObject SceneChange;
    public Image Bonbon;
   
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Candy")
        {
            Candy = true;
            Destroy(other.gameObject);
        }
        if (Candy == true)
        {
            if (Bonbon != null)
            {
                Bonbon.GetComponent<Image>().enabled = true;
            }
        }
        if (other.tag =="Pepe" && Candy == true)
        {
            SpriteRenderer.sprite = Sprite;
            SpriteRendererBaum.sprite = SpriteBaum;
            SceneChange.GetComponent<BoxCollider2D>().enabled = true;
            if (Bonbon != null)
            {
                Destroy(Bonbon);
            }
        }
    }
}
