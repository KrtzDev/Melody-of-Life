using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplode : MonoBehaviour {

    public bool Explode;
    public bool Engage;
    public SpriteRenderer BombStone;
    public Sprite Boom;
    public static bool Spawn;
    public bool Spawn1;
    

    Animator anim;

    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();   
    }
    
    // Update is called once per frame
    void Update ()
    {
        Spawn1 = Spawn;
        if (Engage == true)
        {
            StartCoroutine(WaitExplode());
            Engage = false;
        }
       
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag =="BombStone")
        {
            Engage = true;
            BombStone = other.GetComponent<SpriteRenderer>();
           
        }
        if (Explode == true && other.tag =="BombStone")
        {
            Explode = false;    
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="BombStone")
        {
             Spawn = true;
        }
    }

    IEnumerator WaitExplode()
    {
        anim.SetBool("Explode", true);
        yield return new WaitForSeconds(2);
        BombStone.sprite = Boom;
        yield return new WaitForSeconds(1);
        Explode = true;
    }
}
