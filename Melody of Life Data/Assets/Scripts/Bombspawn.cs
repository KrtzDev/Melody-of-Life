using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombspawn : MonoBehaviour {

    public GameObject Bomb;
    public GameObject BombClone;
    public bool Spawn1;

  
	
	// Update is called once per frame
	void Update () {
        Spawn1 =  BombExplode.Spawn;
        if ( BombExplode.Spawn == true )
        {
            BombClone = Instantiate(Bomb,this.transform.position,Quaternion.identity) as GameObject;
            Bomb = BombClone;
            BombExplode.Spawn = false;
        }
    }
}
