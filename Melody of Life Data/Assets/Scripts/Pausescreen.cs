using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausescreen : MonoBehaviour {

    public static Pausescreen instance;
    public GameObject Gui;
    public static bool PauseActive;
    public GameObject Screen;

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
        
        PauseActive = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && PauseActive == false)
        {
            Gui.GetComponent<Canvas>().enabled = false;
            PauseActive = true;
            Screen.gameObject.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && PauseActive == true)
        {
            Gui.GetComponent<Canvas>().enabled = true;
            PauseActive = false;
            Screen.gameObject.SetActive(false);
        }
        Gui = GameObject.Find("GUI/CanvasGUI");
    }
}
