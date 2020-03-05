using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectNote : MonoBehaviour {

    public int Note;
    public static int NoteGlobal;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Note")
        {
            Gamemanager.Note = Gamemanager.Note + 1;
            PlayerPrefs.SetInt("Note",Gamemanager.Note);
            Destroy(other.gameObject);
        }
    }
}
