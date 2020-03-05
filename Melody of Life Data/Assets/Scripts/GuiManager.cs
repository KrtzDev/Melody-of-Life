using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GuiManager : MonoBehaviour {

    public static GuiManager instance;
    public Image Cookie;
    public Text Note;
    public Sprite Sprite1;
    public Sprite Sprite2;
    public Sprite Sprite3;
    public Sprite Sprite4;
    public GameObject Gui;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        Gui = GameObject.Find("GUI/CanvasGUI");
        Gui.gameObject.SetActive(true);
        Gui.GetComponent<Canvas>().enabled = true;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Note.text = "X " + PlayerPrefs.GetInt("Note");

        if (Gamemanager.Health == 3)
        {
            Cookie.sprite = Sprite1;
        }
        if (Gamemanager.Health == 2)
        {
            Cookie.sprite = Sprite2;
        }
        if (Gamemanager.Health == 1)
        {
            Cookie.sprite = Sprite3;
        }
        if (Gamemanager.Health == 0)
        {
            Cookie.sprite = Sprite4;
        }
    }
}
