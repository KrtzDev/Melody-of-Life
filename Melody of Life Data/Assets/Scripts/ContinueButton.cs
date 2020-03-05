using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ContinueButton : MonoBehaviour {

    public GameObject Gui;
    public GameObject Screen;
	
    public void Continue()
    {
        Gui = GameObject.Find("GUI/CanvasGUI");
        Screen.gameObject.SetActive(false);
        Gui.gameObject.SetActive(true);
        Pausescreen.PauseActive = false;
    }
}
