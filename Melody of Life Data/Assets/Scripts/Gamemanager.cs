using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Gamemanager : MonoBehaviour {

    public static Gamemanager instance;
    public static bool WhichChar;
    public bool Char;
    public static int Health;
    public int CurrentHealth;
    public static int Note;
    public int MNote;


    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        
    }
    void Start()
    {
        Health = 3;
    }

    // Update is called once per frame
    void Update () {
        WhichChar = ChangeCharacter.Character;
        Char = WhichChar;
        CurrentHealth = Health;
        MNote = Note;      
	}
    
}
