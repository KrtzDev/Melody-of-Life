using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladderappear : MonoBehaviour {

    public GameObject Block;
    public GameObject Ladder;
	
	
	// Update is called once per frame
	void Update () {
        if (Block == null)
        {
            Ladder.GetComponent<SpriteRenderer>().enabled = true;
            Ladder.GetComponent<BoxCollider2D>().enabled = true;
        }
	}
}
