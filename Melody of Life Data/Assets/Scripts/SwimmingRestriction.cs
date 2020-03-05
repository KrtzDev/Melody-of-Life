using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwimmingRestriction : MonoBehaviour {

    public GameObject Character;
    public GameObject Target;

    public bool Char;
	// Update is called once per frame
	void Update () {
        Char = ChangeCharacter.Character;
	}
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player" && Char == true)
        {
            Character.transform.position = Target.transform.position;
        }

    }
}
