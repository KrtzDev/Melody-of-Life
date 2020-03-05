using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public Transform SpawnBomb;
    public Transform Target;
	
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag =="Player")
        {
            SpawnBomb.position = Target.position;
        }
    }
}
