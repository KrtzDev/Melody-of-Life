using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleShow : MonoBehaviour
{

    public SpriteRenderer Bubble;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Bubble.GetComponent<SpriteRenderer>().enabled = true;
        }

    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Bubble.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
