using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterScript : MonoBehaviour {

    public GameObject Character;
    public Transform Exit;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Character.transform.position = Exit.transform.position;
    }
}
